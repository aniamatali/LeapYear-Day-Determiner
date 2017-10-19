using System.Collections.Generic;
using System;

namespace Weekday.Models
{
  public class Weekdayer
  {
    private int _inputDay;
    private int _inputMonth;
    private int _inputYear;
    public int totalDay = 1;
    Dictionary<int,int> month = new Dictionary<int,int>(){
      {1,31},{2,28},{3,31},{4,30},{5,31},{6,30},{7,31},{8,31},{9,30},{10,31},{11,30},{12,31} };


    public Weekdayer(int inputMonth, int inputDay, int inputYear)
    {
      _inputDay = inputDay;
      _inputMonth = inputMonth;
      _inputYear = inputYear;

    }

    public int GetDay()
    {
      return _inputDay;
    }

    public int GetMonth()
    {
      return _inputMonth;
    }


    public int GetYear()
    {
      return _inputYear;
    }


    public int dateCalc()
    {
      int dayMonth = 0;
      int leapDay = 0;
      int leapDay100 = 0;
      int leapDay400 = 0;
      int beforeLeap = 0;

      leapDay = _inputYear / 4;
      leapDay100 = _inputYear / 100;
      leapDay400 = _inputYear / 400;

      for(var i=1;i<_inputMonth;i++)
      {
        dayMonth += month[i];
      }

      if(dayMonth < 59 && _inputYear % 4 == 0 && _inputYear % 100 != 0)
      {
        beforeLeap = 1;
      }

      totalDay += ((_inputYear-1)*365)+ (_inputDay-1) + dayMonth + leapDay - leapDay100 + leapDay400 - beforeLeap;

      return totalDay;
    }

    public string dayCalc(int totalDay)
    {
      if (totalDay % 7 == 0)
      {
        return  "Friday";
      }
      else if (totalDay % 7 == 1)
      {
        return  "Saturday";
      }
      else if (totalDay % 7 == 2)
      {
        return  "Sunday";
      }
      else if (totalDay % 7 == 3)
      {
        return  "Monday";
      }
      else if (totalDay % 7 == 4)
      {
        return  "Tuesday";
      }
      else if (totalDay % 7 == 5)
      {
        return  "Wednesday";
      }
      else if (totalDay % 7 == 6)
      {
        return  "Thursday";
      }
      else
      {
        return "blah";
      }
    }




    }


    }
