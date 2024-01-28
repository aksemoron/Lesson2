using System;
using UnityEngine;

namespace Code
{
    public sealed class ExampleSwitch : MonoBehaviour
    {
        public WeekDays Day;
        
        private void OnValidate()
        {
            Debug.LogError(Select(Rainbow.Green));
        }

        private void First(int day)
        {
            if (day == 1)
            {
                Debug.LogError("Понедельник");
            }
            else
            {
                if (day == 2)
                {
                    Debug.LogError("Вторник");
                }
                else
                {
                    if (day == 3)
                    {
                        Debug.LogError("Среда");
                    }
                    else
                    {
                        if (day == 4)
                        {
                            Debug.LogError("Четверг");
                        }
                        else if(day >= 5 && day < 8)
                        {
                            Debug.LogError("Пятница - Воскресенье");
                        }
                        else
                        {
                            Debug.LogError("Что-то пошло не так");
                        }
                    }
                }
            }
        }

        private void Second(int day)
        {
            switch (day)
            {
                case 1 :
                    Debug.LogError("Понедельник"); 
                    break;
                case 2 :
                    Debug.LogError("Вторник"); 
                    break;
                case 3 :
                    Debug.LogError("Среда"); 
                    break;
                case 4 :
                    Debug.LogError("Четверг"); 
                    break;
                case 5 :
                case 6 :
                case 7 :
                    Debug.LogError("Пятница - Воскресенье"); 
                    break;
                 default:
                     Debug.LogError("Что-то пошло не так");
                     break;
            }
        }
        
        private void Third(WeekDays day)
        {
            switch (day)
            {
                case WeekDays.Monday:
                    Debug.LogError("Понедельник");
                    break;
                case WeekDays.Tuesday:
                    Debug.LogError("Вторник");
                    break;
                case WeekDays.Wednesday:
                    Debug.LogError("Среда");
                    break;
                case WeekDays.Thursday:
                    Debug.LogError("Четверг");
                    break;
                case WeekDays.Friday:
                case WeekDays.Saturday:
                case WeekDays.Sunday:
                    Debug.LogError("Пятница - Воскресенье");
                    break;
                default:
                    Debug.LogError("Что-то пошло не так");
                    break;
            }
        }
        private enum Level
        {
            None    = 0,
            Easy    = 1,
            Medium  = 2,
            Hard    = 3
        }
        private void Fourth(Level level, bool isCheater)
        {
            switch (level)
            {
                case Level.None when isCheater:
                    Debug.LogError("100 попыток");
                    break;
                case Level.Easy:
                    Debug.LogError("15 попыток");
                    break;
                case Level.Medium:
                    Debug.LogError("10 попыток");
                    break;
                case Level.Hard:
                    Debug.LogError("5 попыток");
                    break;
                default:
                    Debug.LogError("Что-то пошло не так");
                    break;
            }
        }
        
        private enum Rainbow
        {
            None   = 0,
            Red    = 1,
            Orange = 2,
            Yellow = 3,
            Green  = 4,
            Blue   = 5,
            Indigo = 6,
            Violet = 7
        }
        
        private string Select(Rainbow rainbow)
        {
            switch (rainbow)
            {
                case Rainbow.Red: return "Red";
                case Rainbow.Orange: return "Orange";
                case Rainbow.Yellow: return "Yellow";
                case Rainbow.Green: return "Green";
                case Rainbow.Blue: return "Blue";
                case Rainbow.Indigo: return "Indigo";
                case Rainbow.Violet: return "Violet";
                default: return "Нет такого цвета";
            }
            Debug.LogError(5);
        }

        private string SelectTwo(Rainbow rainbow)
        {
            return rainbow switch
            {
               Rainbow.Red => "Red",
               Rainbow.Orange => "Orange",
               Rainbow.Yellow => "Yellow",
               Rainbow.Green => "Green",
               Rainbow.Blue => "Blue",
               Rainbow.Indigo => "Indigo",
               Rainbow.Violet => "Violet",
               _ => "Нет такого цвета",
            };
        }
        
        private enum Gender
        {
            None   = 0,
            Male   = 1,
            Female = 2
        }

        private string SelectThree(Gender gender, int age)
        {
            return (gender, age) switch
            {
                (Gender.Female, 14) => "Девочка",
                (Gender.Female, 18) => "Девушка",
                (Gender.Female, 30) => "Женщина",
                (Gender.Female, 70) => "Бабушка",
            };
        }
    }
}
