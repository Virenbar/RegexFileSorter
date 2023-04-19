﻿using System.Diagnostics;

namespace RegexFileSorterWF
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.AddStyleDataBindigs();
            L_Version.Text = $"v{Application.ProductVersion}";
        }

        private static void OpenURL(string url) => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        private void LL_Icons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LL_Icons.LinkVisited = true;
            OpenURL("https://icons8.com");
        }

        private void LL_RFS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LL_Control.LinkVisited = true;
            OpenURL("https://github.com/Virenbar/RegexFileSorter");
        }
    }
}