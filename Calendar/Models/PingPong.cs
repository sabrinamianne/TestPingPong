namespace Calendar
{ 
  public class PingPong
  {
    public bool IsPingPong(int userNumber)
    {
      if (userNumber % 3 == 0)
      {
      return true;
      }
      else if (userNumber % 5 ==0)
      {
      return true;
      } 
      else
      {
        return userNumber % 15 == 0;   
      }    
    }
  }
}




