using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Text;

namespace Casasoft.BBS.UI
{
    public class TextScreenBase : ScreenBase
    {
        protected string Text = string.Empty;
        protected void ReadText(string name)
        {
            string assets = ConfigurationManager.AppSettings.Get("assets");
            NameValueCollection texts = (NameValueCollection)ConfigurationManager.GetSection("Texts");
            string filename = Path.Combine(assets, texts[name]);
            Text = File.ReadAllText(filename);
        }

        public override IScreen Show()
        {
            ShowText();
            return null;
        }

        protected void ShowText()
        {
            ShowText(Text);
        }

        protected void ShowText(string txt)
        {
            Console.Write(txt);
        }

    }
}
