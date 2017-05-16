using CalcLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalc
{
    public partial class Form1 : Form
    {
        private CalcLibrary.Calc Calc { get; set; } 

        public Form1()
        {
            InitializeComponent();
            Calc = new CalcLibrary.Calc();

            //cbOper.Items.AddRange(Calc.Operations.Select(o=> o.Name).ToArray());

            cbOper.DataSource = Calc.Operations;
            cbOper.DisplayMember = "Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LResult.Text = "";
            
            var oper = cbOper.Text;

            object result = null;

            var moreArgs = cbOper.SelectedItem is IOperationArgs;

            var args = new List<object>();
            if (moreArgs)
            {
                //var values = tbMore.Text.Split(' ');
                args.AddRange(tbMore.Text.Split(' '));
            }
            else
            {
                var x = TBX.Text;
                var y = TBY.Text;
                args.Add(x);
                args.Add(y);
            }

            try
            {

                result = Calc.ExecuteNew(cbOper.SelectedValue as IOperation, args.ToArray());
                //result = Calc.ExecuteNew(oper, args.ToArray());


            }
            catch (DivideByZeroException ex)
            {
                LResult.Text = $"DivideByZero: {ex.Message}";
            }
            catch (Exception ex)
            {
                LResult.Text = $"Error: {ex.Message}";
            }

            if (result != null)
            {
                LResult.Text = $"{result}";
            }
        }

        private void cbOper_SelectedIndexChanged(object sender, EventArgs e)
        {
             var moreArgs = cbOper.SelectedItem is IOperationArgs;

           /* var oper = Calc.Operations
                .Where(o=> o is )
                .FirstOrDefault(o => o.Name ==  cbOper.Text );

            var moreArgs = oper is IOperationArgs;*/

            panTwoArgs.Visible = !moreArgs;
            panMoreArgs.Visible = moreArgs;
        }
    }
}
