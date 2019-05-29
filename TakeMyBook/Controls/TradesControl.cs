using System.Windows.Forms;
using TakeMyBook.Services;

namespace TakeMyBook
{
    public partial class TradesControl : UserControl
    {
        public TradesService Trades { get; set; } = new TradesService();

        public TradesControl()
        {
            InitializeComponent();

            try
            {
                tradeViewBindingSource.DataSource = Trades.GetTrades();
            }
            catch { }
        }

        public void updateTrades()
        {
            try
            {
                tradeViewBindingSource.DataSource = Trades.GetTrades();
            }
            catch { }
        }
    }
}
