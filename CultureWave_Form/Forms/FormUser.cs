using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    public partial class FormUser: Form
    {
        FormData formData;
        public FormUser(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }
    }
}
