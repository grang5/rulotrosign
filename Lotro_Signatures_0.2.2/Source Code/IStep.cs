using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace LotroSignatures
{
    public delegate void StepOKChangedHandler(IStep source, bool ok);
    public interface IStep
    {
        bool OK
        {
            get;
        }
        Control Control
        {
            get;
        }
        event StepOKChangedHandler OKChanged;
        void UpdateLanguage(ResourceManager man);
    }
}
