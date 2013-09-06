using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateData;
using TemplateValidator;

namespace FormsTemplateHelper
{
    public partial class UpdateForm : Form
    {
        //Code to initialize the form
        public UpdateForm()
        {
            InitializeComponent();

            var templateTypes = TemplateDataHelper.GetTemplateTypes();
            foreach (var templateType in templateTypes)
            {
                comboBox1.Items.Add(new ComboboxItem()
                {
                    Text = string.Format("{0} ({1})", templateType.TemplateTypeCode, templateType.Description),
                    Value = templateType.ContractTemplateTypeId
                });
            }
        }

        //Code to run when the template type name dropdown changes
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            var templates = TemplateDataHelper.GetTemplatesByType((int)((ComboboxItem)comboBox1.SelectedItem).Value);
            foreach (var template in templates)
            {
                comboBox2.Items.Add(new ComboboxItem()
                {
                    Text = string.Format("{0}", template.TemplateName),
                    Value = template.ContractTemplateId
                });
            }
            textBox1.Text = string.Empty;
        }

        //Logic to update the textbox when a template name is selected
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = TemplateDataHelper.GetTemplateById((int)((ComboboxItem)comboBox2.SelectedItem).Value).HtmlContent;
        }

        //Logic to update the database
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)((ComboboxItem)comboBox2.SelectedItem).Value;
                string html = textBox1.Text;
                if (string.IsNullOrEmpty(html))
                {
                    throw new ArgumentNullException("Html Content is null or empty");
                }

                TemplateDataHelper.UpdateTemplate(id, html);

                MessageBox.Show("The Database has been Updated", "DB Updated",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("The Database has not been updated: {0}",ex.Message), "Database Update Failure",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TemplateValidatorHelper.IsValidXslt(textBox1.Text))
            {
                MessageBox.Show("The attached HTML is valid XSLT", "Valid",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The attached HTML is NOT valid XSLT", "Invalid",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string html = string.Empty;
                if (TemplateValidatorHelper.IsValidXslt(textBox1.Text))
                {
                    html = TemplateValidatorHelper.GetTransformedXslt(textBox1.Text);
                }
                else
                {
                    html = textBox1.Text;
                }
                byte[] bytes = TemplateValidatorHelper.GetPdfFromHtml(html);

                var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                var fullFileName = Path.Combine(desktopFolder, "test.pdf");
                var fs = new FileStream(fullFileName, FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();

                MessageBox.Show("PDF was created and saved to your desktop.  It will be opened when you click OK", "PDF Created",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error Creating PDF: {0}", ex.Message), "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
