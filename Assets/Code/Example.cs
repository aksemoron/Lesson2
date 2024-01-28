namespace Code
{
    public sealed class Example
    {
        private void NameMethod(Character character)
        {
            if (character.Type == WeekDays.Friday)
            {
                character.Damage(100);
            }
            character.Type = WeekDays.Friday;
            int day = (int)WeekDays.Wednesday;
        }
        
        private void NameMethod2(Character character)
        {
            int damage = character.Type == WeekDays.Friday ? 100 : 10;
            if (character.Type == WeekDays.Friday)
            {
                damage = 100;
            }
            else
            {
                damage = 10;
            }
            character.Damage(damage);
        }
    }
}
