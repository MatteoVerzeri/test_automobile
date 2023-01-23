using Automobile.Libreria;

namespace automobile
{
    public class UnitTest1
    {
        Auto auto;
        [Fact]
        public void Testaccendinoguidatore()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            Assert.Throws<Exception>(() => auto.accendi());
        }
        [Fact]
        public void Testaccendiconguidatore()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            var exception = Record.Exception(() => auto.accendi());

            //Assert
            Assert.Null(exception);
        }
        /*[Fact]
        public void Testaccendinoguidatoreeccezione()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            var exception = Record.Exception(() => auto.accendi());

            //Assert
            Assert.Null(exception);
        }*/
        [Fact]
        public void Testspegnieccezione()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            auto.accendi();
            auto.acceleratore(20);
            Assert.Throws<Exception>(() => auto.spegni());
        }
        [Fact]
        public void Testspegninoeccezione()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            auto.accendi();
            auto.acceleratore(20);
            auto.decelerazione(20);
            var exception = Record.Exception(() => auto.spegni());

            //Assert
            Assert.Null(exception);
        }
        [Fact]
        public void Testspegnisenzaaccensione()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            auto.acceleratore(20);
            auto.decelerazione(20);
            Assert.Throws<Exception>(() => auto.spegni());
        }
        [Fact]
        public void Testinfrazioni()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            auto.accendi();
            auto.impostalimite(19);
            auto.acceleratore(20);
            auto.decelerazione(20);
            auto.acceleratore(20);
            auto.decelerazione(1);
            auto.acceleratore(1);
            Assert.True(auto.ottieniinfrazioni()==3);
        }
        [Fact]
        public void Testdiscesaguidatore()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            auto.acceleratore(20);
            auto.decelerazione(20);
            var exception = Record.Exception(() => auto.discesaguidatore());

            //Assert
            Assert.Null(exception);
        }
        [Fact]
        public void Testdiscesaguidatoreconeccezione()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            auto.salitaguidatore();
            auto.acceleratore(20);
            Assert.Throws<Exception>(() => auto.discesaguidatore());

        }
        [Fact]
        public void Testdiscesaguidatoreconeccezione2()
        {
            auto = new Auto("1yy818", "er234tg", "dkdod", "ciao2");
            Assert.Throws<Exception>(() => auto.discesaguidatore());
        }
    }
}