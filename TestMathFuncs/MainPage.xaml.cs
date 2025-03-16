
using MathFuncs;

namespace TestMathFuncs
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MyMathFuncs allMathFuncs = new MyMathFuncs();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            double a = 123;
            double b = 456;
            double result;

            if (count == 1)
            {
                result = allMathFuncs.Add(a,b);
                CounterBtn.Text = $"Testing Add Function : {a} + {b} = {result}";
            }
            else if (count == 2)
            {
                result = allMathFuncs.Subtract(a, b);
                CounterBtn.Text = $"Testing Subtract Function : {a} - {b} = {result}";
            }
            else if (count == 3)
            {
                result = allMathFuncs.Multiply(a, b);
                CounterBtn.Text = $"Testing Multiply Function : {a} * {b} = {result}";
            }
            else if(count == 4)
            {
                result = allMathFuncs.Divide(a, b);
                CounterBtn.Text = $"Testing Divide Function : {a} / {b} = {result}";
            }
            else
            {
                CounterBtn.Text = $"Click me";
                count = 0;
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
