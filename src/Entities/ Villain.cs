namespace GFT_JogoRPG.src.Entities
{
    public class  Villain : Hero
    {
        public Villain (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 5)
            {
                return this.Name + " defendeu os golpes de Arus e Jennica, ganhou Bonus de " + Bonus;
            }
            else
            {
                return this.Name + " não conseguiu se defender e perdeu o Bonus de " + Bonus + " " + "pontos!"; 
            }
        }
    }
}