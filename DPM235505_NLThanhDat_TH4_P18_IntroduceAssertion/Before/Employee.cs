namespace DPM235505_NLThanhDat_TH4_P18_IntroduceAssertion.Before
{
    public class Employee
    {
        private double _expenseLimit = -1;
        private Project? _primaryProject = new Project(); // Dùng ? để cho phép Null

        public double GetExpenseLimit()
        {
            // Code ngầm định _primaryProject không bị Null, rất nguy hiểm
            return (_expenseLimit != -1) ? _expenseLimit : _primaryProject!.GetMemberExpenseLimit();
        }
    }
}