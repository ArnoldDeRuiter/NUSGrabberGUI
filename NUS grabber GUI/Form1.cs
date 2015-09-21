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

            lblAuthor.Text = "NUSGrabber by: \r\nCrediar";
            lblOtherAuthor.Text = "GUI by: \r\nAdr990/Arndroid";

            txtSearchBox.Enabled = false;
            cmbTitles.Enabled = false;
            cmbVersions.Enabled = false;
            btnDownload.Enabled = false;


            lblAlert.ForeColor = Color.Tomato;
            lblAlert.Text = "No title to be found.";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cgbSystemTitles.Visible = false;
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

        List<ComboboxItem> finalGameUpdates;
        List<ComboboxSysItem> finalSystemTitles;
        private void PrintDocument(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            finalGameUpdates = new List<ComboboxItem>();
            finalSystemTitles = new List<ComboboxSysItem>();
            int progress = 0;
            //When page loaded
            bool skipFirst = false, skipSecond = false;
            foreach (HtmlElement table in ((WebBrowser)sender).Document.GetElementsByTagName("table"))
            {
                progress++;
                progress = (progress == 100) ? 0 : progress;
                prBar.Value = progress;
                if (skipFirst && skipSecond)
                {
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
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbi.Title_ID = abc; cbi.Desc = abc; cbi.Versions = abc; continue; }
                                    cbi.Title_ID = abc;
                                }
                                //DESC
                                if (columncount == 2)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbi.Title_ID = abc; cbi.Desc = abc; cbi.Versions = abc; continue; }
                                    cbi.Desc = abc;
                                }
                                //VER
                                if (columncount == 4)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbi.Title_ID = abc; cbi.Desc = abc; cbi.Versions = abc; continue; }
                                    cbi.Versions = abc;
                                }
                                //REG
                                if (columncount == 5)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbi.Title_ID = abc; cbi.Desc = abc; cbi.Versions = abc; continue; }
                                    cbi.Desc = abc + " - " + cbi.Desc;
                                }
                                columncount++;
                            }
                            finalGameUpdates.Add(cbi);
                        }
                        break; //We got the table(s) we wanted, now stop.
                    }
                }
                else if (skipFirst)
                {
                    progress++;
                    progress = (progress == 100) ? 0 : progress;
                    prBar.Value = progress;
                    if (table.GetAttribute("className").Equals("wikitable sortable jquery-tablesorter") || table.GetAttribute("className").Equals("wikitable sortable")) //Removing jquery-tablesorter for some... thanks voddy!
                    {
                        foreach (HtmlElement tr in table.GetElementsByTagName("tr"))
                        {
                            progress++;
                            progress = (progress == 100) ? 0 : progress;
                            prBar.Value = progress;
                            int columncount = 1;
                            ComboboxSysItem cbisys = new ComboboxSysItem();
                            foreach (HtmlElement td in tr.GetElementsByTagName("td"))
                            {
                                //TITLE
                                if (columncount == 1)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbisys.Title_ID = abc; cbisys.Desc = abc; cbisys.Versions = abc; continue; }                                    
                                    cbisys.Title_ID = abc;
                                }
                                //DESC
                                if (columncount == 2)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbisys.Title_ID = abc; cbisys.Desc = abc; cbisys.Versions = abc; continue; }
                                    cbisys.Desc = abc;
                                }
                                //VER
                                if (columncount == 4)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbisys.Title_ID = abc; cbisys.Desc = abc; cbisys.Versions = abc; continue; }
                                    cbisys.Versions = abc;
                                }
                                //REG
                                if (columncount == 5)
                                {
                                    string abc = null;
                                    try { abc = td.InnerText.Trim(); } catch (Exception) { cbisys.Title_ID = abc; cbisys.Desc = abc; cbisys.Versions = abc; continue; }   
                                    cbisys.Desc = abc + " - " + cbisys.Desc;
                                }
                                columncount++;
                            }
                            finalSystemTitles.Add(cbisys);
                        }

                        skipSecond = true;
                    }   
                }
                else
                {
                    skipFirst = true;
                }
            }
            
            //Add to Game Updates combobox.
            foreach (var t in finalGameUpdates)
            {
                if (t.Desc != null)
                {
                    cmbTitles.Items.Add(t);
                    cmbTitles.SelectedIndex = 0;
                }
            }

            //Add to System Titles combobox.
            foreach (var s in finalSystemTitles)
            {
                if (s.Desc != null)
                {
                    cmbSysTitles.Items.Add(s);
                    cmbSysTitles.SelectedIndex = 0;
                }
            }

            lblLoad.Text = "";//Done!
            prBar.Visible = false;

            txtSearchBox.Enabled = true;
            cmbTitles.Enabled = true;
            cmbVersions.Enabled = true;
            btnDownload.Enabled = true;
            btnDownUp.Enabled = true;//UPdate Games
            btnDownSys.Enabled = true;//SYStem Titles

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
            //If on Game Updates
            if (cgbGameUpdates.Visible)
            {
                bool empty = false;
                try
                {
                    (cmbTitles.SelectedItem as ComboboxItem).Title_ID.ToString();
                }
                catch (Exception)
                {
                    lblAlert.Visible = true;
                    //throw;
                    empty = true;
                }
                if (!empty)
                {
                    try
                    {
                        string Title_ID = (cmbTitles.SelectedItem as ComboboxItem).Title_ID.ToString();
                        string output = Title_ID.Replace("00050000-", "0005000E");

                        if (cmbSysVersions.SelectedText == "Latest")
                        {
                            //... Nothing
                        }
                        else
                        {
                            string versionnr = cmbVersions.SelectedText;
                            if (versionnr.Length < 1)
                            {
                                versionnr = "";
                            }
                            else
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
            }
            //If on System Titles
            else if (cgbSystemTitles.Visible)
            {
                bool empty = false;
                try
                {
                    (cmbSysTitles.SelectedItem as ComboboxSysItem).Title_ID.ToString();
                }
                catch (Exception)
                {
                    lblAlert.Visible = true;
                    //throw;
                    empty = true;
                }
                if (!empty)
                {
                    try
                    {
                        string Title_ID = (cmbSysTitles.SelectedItem as ComboboxSysItem).Title_ID.ToString();
                        string output = Title_ID.Replace("-", "");

                        if (cmbVersions.SelectedText == "Latest")
                        {
                            //... Nothing
                        }
                        else
                        {
                            string versionnr = cmbSysVersions.SelectedText;
                            if (versionnr.Length < 1)
                            {
                                versionnr = "";
                            }
                            else
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
            }

        }
        
        private void btnDownUp_Click(object sender, EventArgs e)
        {
            //Open Game Updates cgp
            if (!cgbGameUpdates.Visible)
            {
                Sliderx.Animate(cgbSystemTitles as Control, Sliderx.Effect.Slide, 500, 360);
                Slider.Animate(cgbGameUpdates as Control, Slider.Effect.Slide, 500, 360);
            }
        }

        private void btnDownOther_Click(object sender, EventArgs e)
        {
            //Open System Titles cgp
            if (!cgbSystemTitles.Visible)
            {
                Slider.Animate(cgbGameUpdates as Control, Slider.Effect.Slide, 500, 360);
                Sliderx.Animate(cgbSystemTitles as Control, Sliderx.Effect.Slide, 500, 360);
            }
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
            if (cmbTitles.SelectedText != null || cmbTitles.SelectedText != "")
            {
                lblAlert.Visible = false;

                cmbVersions.Items.Clear();
                string vers = (cmbTitles.SelectedItem as ComboboxItem).Versions.ToString();
                string[] versAr = vers.Split(',');

                cmbVersions.Items.Add("Latest");
                foreach (var vr in versAr)
                {
                    if (vr != null)
                    {
                        cmbVersions.Items.Add(vr);
                        cmbVersions.SelectedIndex = 0;
                    }
                }
            }
            
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            cmbTitles.Items.Clear();
             if (txtSearchBox.Text != "")
             {
                 foreach (var t in finalGameUpdates)
                 {
                    string desc = t.Desc;
                    if (desc != null) { 
                        if (desc.IndexOf(txtSearchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0) //Case insensitive.
                        {
                            cmbTitles.Items.Add(t);
                            cmbTitles.SelectedIndex = 0;
                        }
                    } else {
                        lblAlert.Visible = true;
                    }
                }
             }
             else
             {
                foreach (var t in finalGameUpdates)
                 {
                     if (t.Desc != null)
                     {
                         cmbTitles.Items.Add(t);
                         cmbTitles.SelectedIndex = 0;
                     }
                 }
             }
        }

        private void cmbSysTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSysTitles.SelectedText != null || cmbSysTitles.SelectedText != "")
            {
                lblAlert.Visible = false;

                cmbSysVersions.Items.Clear();
                string vers = (cmbSysTitles.SelectedItem as ComboboxSysItem).Versions.ToString();
                string[] versSysAr = vers.Split(',');

                cmbSysVersions.Items.Add("Latest");
                foreach (var vrS in versSysAr)
                {
                    if (vrS != null)
                    {
                        cmbSysVersions.Items.Add(vrS.Trim());
                        cmbSysVersions.SelectedIndex = 0;
                    }
                }
            }
        }

        private void txtSysSearchBox_TextChanged(object sender, EventArgs e)
        {
            cmbSysTitles.Items.Clear();
            if (txtSysSearchBox.Text != "")
            {
                foreach (var s in finalSystemTitles)
                {
                    string desc = s.Desc;
                    if (desc != null)
                    {
                        if (desc.IndexOf(txtSysSearchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0) //Case insensitive.
                        {
                            cmbSysTitles.Items.Add(s);
                            cmbSysTitles.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        lblAlert.Visible = true;
                    }
                }
            }
            else
            {
                foreach (var s in finalSystemTitles)
                {
                    if (s.Desc != null)
                    {
                        cmbSysTitles.Items.Add(s);
                        cmbSysTitles.SelectedIndex = 0;
                    }
                }
            }
        }
    }
}
