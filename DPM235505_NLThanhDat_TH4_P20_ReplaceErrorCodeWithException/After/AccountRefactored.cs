using System;

namespace DPM235505_NLThanhDat_TH4_P20_ReplaceErrorCodeWithException.After
{
    public class AccountRefactored
    {
        private int _balance = 1000;

        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                // Ném thẳng Exception, chương trình bắt buộc phải xử lý lỗi này
                throw new ArgumentException("Số dư không đủ để rút tiền!");
            }
            _balance -= amount;
        }
    }
}