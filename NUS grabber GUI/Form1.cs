using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NUS_grabber_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(247, 247, 247); //Modern UI white
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitleForm.Text = this.Text;
            // Create a WebBrowser instance. 
            WebBrowser webBrowserForPrinting = new WebBrowser();

            webBrowserForPrinting.ScriptErrorsSuppressed = true;

            prBar.Value = 50;
            // Add an event handler that prints the document after it loads.
            webBrowserForPrinting.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(PrintDocument);

            // Set the Url property to load the document.
            webBrowserForPrinting.Url = new Uri(@"http://wiiubrew.org/wiki/Title_database");
        }
        
        private void PrintDocument(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            int progress = 0;
            List<ComboboxItem> temp = new List<ComboboxItem>();
            //When page loaded
            bool skipFirst = false, skipSecond = false;
            foreach (HtmlElement table in ((WebBrowser)sender).Document.GetElementsByTagName("table"))
            {
                progress++;
                progress = (progress == 100) ? 0 : progress;
                prBar.Value = progress;
                if (skipFirst && skipSecond) { 
                    if (table.GetAttribute("className").Equals("wikitable sortable jquery-tablesorter") || table.GetAttribute("className").Equals("wikitable sortable")) //Removing jquery-tablesorter for some... thanks voddy!
                    {
                        foreach (HtmlElement tr in table.GetElementsByTagName("tr"))
                        {
                            progress++;
                            progress = (progress == 100) ? 0 : progress;
                            prBar.Value = progress;
                            int columncount = 1;
                            ComboboxItem cbi = new ComboboxItem();
                            foreach (HtmlElement td in tr.GetElementsByTagName("td"))
                            {   
                                //TITLE
                                if (columncount == 1)
                                {
                                    cbi.Title_ID = "null";
                                    string abc = (td.InnerText.Trim() != null || td.InnerText.Trim() != "") ? td.InnerText.Trim() : "null";
                                    cbi.Title_ID = abc;
                                }
                                //DESC
                                if (columncount ==2)
                                {
                                    cbi.Desc = "null";
                                    string abc = (td.InnerText.Trim() != null || td.InnerText.Trim() != "") ? td.InnerText.Trim() : "null";
                                    cbi.Desc = abc;
                                }
                                //VER
                                if (columncount == 4)
                                {
                                    cbi.Versions = "null";
                                    string abc = (td.InnerText.Trim() != null || td.InnerText.Trim() != "") ? td.InnerText.Trim() : "null";
                                    cbi.Versions = abc;
                                }
                                //REG
                                if (columncount == 5)
                                {
                                    string abc = (td.InnerText.Trim() != null || td.InnerText.Trim() != "") ? td.InnerText.Trim() : "null";
                                    cbi.Desc = abc + " - " + cbi.Desc;                                    
                                }
                                columncount++;
                            }
                            temp.Add(cbi);
                        }
                        break; //We got the table we wanted, now stop.
                    }
                } else if (skipFirst)
                {
                    skipSecond = true;
                } else
                {
                    skipFirst = true;
                }
            }



            foreach (var t in temp)
            {
                if (t.Desc != null)
                {
                    cmbTitles.Items.Add(t);
                    cmbTitles.SelectedIndex = 0;
                }
            }
            

            lblLoad.Text = "";//Done!
            prBar.Visible = false;
            

            // Dispose the WebBrowser now that the task is complete. 
            ((WebBrowser)sender).Dispose();
        }

        #region Minimalize/Close button events
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pbClose_MouseHover(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Tomato;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Transparent;
        }

        private void pbClose_MouseDown(object sender, MouseEventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#BF4A35");
            pbClose.BackColor = col;
        }

        private void pbMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMinimalize_MouseHover(object sender, EventArgs e)
        {
            pbMinimalize.BackColor = Color.LightBlue;
        }

        private void pbMinimalize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimalize.BackColor = Color.Transparent;
        }

        private void pbMinimalize_MouseDown(object sender, MouseEventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#9BC0CC");
            pbMinimalize.BackColor = col;

        }
        #endregion

        #region Vars
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion

        #region FormBorderStyle == None - This makes it draggable
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {

            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string Title_ID = (cmbTitles.SelectedItem as ComboboxItem).Title_ID.ToString();
                string output = Title_ID.Replace("00050000-", "0005000E");


                if (cmbVersions.SelectedText == "Latest")
                {
                    //... Niets
                } else
                {
                    string versionnr = cmbVersions.SelectedText;
                    if (versionnr.Length < 1)
                    {
                        versionnr = "";
                    } else
                    {
                        versionnr.Substring(1, versionnr.Length - 1);
                    }                    
                    output += " " + versionnr;
                }

                Process.Start(@"crediar\NUSgrabber.exe", output.Trim());
            }
            catch (Exception exep)
            {
                MessageBox.Show("Could'not open NUSgrabber.exe\n\nDetailed error:\n\n" + exep.ToString());
            }
            
        }

        private void btnDownUp_Click(object sender, EventArgs e)
        {
            //Nothing yet.
        }

        private void btnDownOther_Click(object sender, EventArgs e)
        {
            //Nothing yet.
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 30, 450, 30);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void cmbTitles_TextChanged(object sender, EventArgs e)
        {
            cmbVersions.Items.Clear();
            string vers = (cmbTitles.SelectedItem as ComboboxItem).Versions.ToString();
            string[] versAr = vers.Split(',');


            cmbVersions.Items.Add("Latest");
            foreach (var vr in versAr)
            {
                if (vr!= null)
                {
                    cmbVersions.Items.Add(vr);
                    cmbVersions.SelectedIndex = 0;
                }
            }
        }
    }
}
