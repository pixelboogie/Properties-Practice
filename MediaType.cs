using System;

namespace CSharp_Inheritance
{
    class MediaType
    {

        public String Title  { get; private set; }
        public String Loanee { get; private set; } = "";
        public bool OnLoan { get; private set; } = false;

        public string OnLoanDisplayText
        {
            get{
                if (OnLoan)
                {
                    if (!string.IsNullOrEmpty(Loanee))
                    {
                        return " (Currently on loan to " + Loanee + ")";
                    }
                    else
                    {
                        return " (Currently on loan)";
                    }                
                }else{
                    return "";
                }
            }
        }
        public MediaType(string title){

            if(string.IsNullOrEmpty(title))
            {
                throw new Exception("A media type must have a title.");
            }
            
            Title = title;

        }
        
        public void Loan()
        {
            OnLoan = true;
        }
        
        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }
        
        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }

}
