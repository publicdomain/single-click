// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SingleClick
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    using Gma.System.MouseKeyHook;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The m global hook.
        /// </summary>
        private IKeyboardMouseEvents m_GlobalHook;

        /// <summary>
        /// The passed.
        /// </summary>
        private int passed = 0;

        /// <summary>
        /// The blocked.
        /// </summary>
        private int blocked = 0;
        /// <summary>
        /// The suppress click.
        /// </summary>
        private bool suppressClick = false;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SingleClick.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check for Star(t) vs Sto(p)
            if (this.startStopButton.Text.EndsWith("t", StringComparison.InvariantCulture))
            {
                // Change to stop
                this.startStopButton.Text = "&Stop";
                this.startStopButton.ForeColor = Color.Red;

                // Start
                this.Subscribe();
            }
            else
            {
                // Reset to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.DarkGreen;

                // Stop
                this.Unsubscribe();
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Stop [Can be made DRY with a separate function]
            if (this.startStopButton.Text.EndsWith("p", StringComparison.InvariantCulture))
            {
                // Reset to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.DarkGreen;

                // Stop
                this.Unsubscribe();
            }

            // Toggle back
            this.suppressClick = false;

            // Reset counters
            this.passed = 0;
            this.blocked = 0;

            // TODO Update status labels [Can be made DRY with a separate function]
            this.passedToolStripStatusLabel.Text = this.passed.ToString();
            this.blockedToolStripStatusLabel.Text = this.blocked.ToString();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.reddit.com/r/software/comments/uyeedl/im_looking_for_software_that_disables_my_left/");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/single-click");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"One circle icon by Clker-Free-Vector-Images - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/one-circle-orange-white-number-1-38484/{Environment.NewLine}{Environment.NewLine}" +
                $"Reddit icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.redditinc.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend supporters
            licenseText = $"RELEASE SUPPORTERS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}* Kathryn S.{Environment.NewLine}* Y0himba{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: u/kiingkiller{ Environment.NewLine}Reddit.com{Environment.NewLine}Day #147, Week #21 @ May 27, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Globals the hook mouse up ext.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void GlobalHookMouseUpExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!this.suppressClick)
                {
                    // First click, toggle
                    this.suppressClick = true;

                    this.passed++;

                    // Enable timer
                    this.clickTimer.Start();
                }
                else
                {
                    e.Handled = true;

                    this.blocked++;
                }
            }

            // Update status labels
            this.passedToolStripStatusLabel.Text = this.passed.ToString();
            this.blockedToolStripStatusLabel.Text = this.blocked.ToString();
        }

        /// <summary>
        /// Globals the hook mouse down ext.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.suppressClick)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Subscribe this instance.
        /// </summary>
        private void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt += GlobalHookMouseUpExt;
        }

        /// <summary>
        /// Unsubscribe this instance.
        /// </summary>
        public void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt -= GlobalHookMouseUpExt;

            m_GlobalHook.Dispose();
        }

        /// <summary>
        /// Handles the time numeric up down value changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTimeNumericUpDownValueChanged(object sender, EventArgs e)
        {
            // Set timer interval
            this.clickTimer.Interval = (int)this.timeNumericUpDown.Value;
        }

        /// <summary>
        /// Handles the click timer tick.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnClickTimerTick(object sender, EventArgs e)
        {
            // Toggle back
            this.suppressClick = false;

            // Disable timer
            this.clickTimer.Stop();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}
