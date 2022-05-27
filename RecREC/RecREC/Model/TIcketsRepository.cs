using System;

public class ProductRepository
{
    private string connectionString;
   
        public ProductRepository()
        {
             connectionString = "Server=devlab.thenotepad.eu; Database=REC_RC07;User ID=REC_RC07;Password=REC_RC07;Trusted_Connection=False;Encrypt=True;MultipleActiveResultSets=True;"



        }
	public IDbConntection Conntection
    {
        get 
            return new Sql
    }

}
