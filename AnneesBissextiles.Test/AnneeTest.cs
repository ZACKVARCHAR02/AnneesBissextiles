namespace AnneesBissextiles.Test
{
    
    public class AnneeTest
    {
        private const int var400 = 400;

        [Theory(DisplayName ="Les ann�es qui ne sont pas divisble par 400 ne sont jamais bissextiles.")]
        [InlineData(2000,true)] // ann�e divisible par 400
        [InlineData(1800, false)] // ann�e divisible par 100, mais pas par 400 
        [InlineData(100, false)] // ann�e divisble par 100, mais par 400
        [InlineData(400, true)] // ann�e divisble par 400
        [InlineData(800, true)] // ann�e divisble par 400
        public void EstBissextile_Test_Divisible_Par_400(int annee, bool expected) 
        {
            var res = AnneeBis.EstBissextile(annee);

            Assert.Equal(expected, res);

        }

        [Theory(DisplayName = "Les ann�es qui ne sont pas divisble par 4 ne sont jamais bissextiles")]
        [InlineData(1823, false)] // ann�e pas divisble par 4
        [InlineData(1, false)] // ann�e pas divisble par 4
        [InlineData(4, true)] // ann�e divisble par 4
        [InlineData(1960, true)] // ann�e divisble par 4
        [InlineData(1239, false)] // ann�e pas divisble par 4
        public void EstBissextile_Test_Divisible_Par_4(int annee, bool expected)
        {
            var res = AnneeBis.EstBissextile(annee);

            Assert.Equal(expected, res);
        }

        [Theory(DisplayName = "Les ann�es divisibles par 4, mais pas par 100 sont bissextiles")]
        [InlineData(2000, true)] // ann�e divisble par 4 et par 100 (Car divisble par 400)
        [InlineData(2100, false)] // ann�e divisble par 4 et par 100
        [InlineData(2024, true)] // ann�e divisble par 4 et divisible pas par 100
        [InlineData(2012, true)] // ann�e divisble par 4 et divisible par 100
        [InlineData(1996, true)] // ann�e divisble par 4 et divisible pas par 100
        [InlineData(2030, false)] // ann�e divisble par 4 et divisible par 100


        public void EstBissextile_Test_Divisible_Par_4_Pas_Par100(int annee, bool expected)
        {
            var res = AnneeBis.EstBissextile(annee);

            Assert.Equal(expected, res);
        }
        [Fact(DisplayName ="Cas exceptionnel pour l'ann�e 0")]
        public void Est_Bissextile_Test_0()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => AnneeBis.EstBissextile(0));
        }
    }
}