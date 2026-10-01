using System.Diagnostics;

namespace DPM235505_NLThanhDat_TH4_P18_IntroduceAssertion.After
{
    public class EmployeeRefactored
    {
        private double _expenseLimit = -1;
        private ProjectRefactored? _primaryProject = new ProjectRefactored();

        public double GetExpenseLimit()
        {
            // Thêm Assertion: Khẳng định _primaryProject phải khác Null
            Debug.Assert(_primaryProject != null, "Dự án chính không được để trống!");
            return (_expenseLimit != -1) ? _expenseLimit : _primaryProject.GetMemberExpenseLimit();
        }
    }
}