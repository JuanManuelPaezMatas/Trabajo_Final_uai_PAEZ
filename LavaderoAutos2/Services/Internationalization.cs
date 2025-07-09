using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoAutos2.Services
{
    internal class Internationalization
    {   
        List<IidiomaObserver> _observadores ; 
        private string _idioma;
        private Internationalization() {

          _observadores= new List<IidiomaObserver>();
          _idioma = "ES";
        }
        public string Idioma {  get { return _idioma; } }

        private static Internationalization instancia;

        public static Internationalization Instancia { get { if (instancia == null) { instancia = new Internationalization(); }return instancia; } }

        public void suscribir(IidiomaObserver observador)
        {
            if (!this._observadores.Contains(observador)) {
               this._observadores.Add(observador);
            }

        }

        public void dessuscribir(IidiomaObserver observador)
        {
            if (this._observadores.Contains(observador))
            {
                this._observadores.Remove(observador);
            }

        }

        public void CambiarIdioma(string idioma)
        {
            this._idioma = idioma;

            foreach (IidiomaObserver observer in this._observadores) {

                observer.CambiarIdioma(idioma);
            
            }

        }

    }
}
