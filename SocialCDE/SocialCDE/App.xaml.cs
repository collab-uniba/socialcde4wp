using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SocialCDE
{
    public partial class App : Application
    {
        /// <summary>
        /// Consente di accedere facilmente al frame radice dell'applicazione Phone.
        /// </summary>
        /// <returns>Frame radice dell'applicazione Phone.</returns>
        public PhoneApplicationFrame RootFrame { get; private set; }

        /// <summary>
        /// Costruttore per l'oggetto Applicazione.
        /// </summary>
        public App()
        {
            // Gestore globale per le eccezioni non rilevate. 
            // Si noti che le eccezioni generate da ApplicationBarItem.Click non verranno rilevate.
            UnhandledException += Application_UnhandledException;

            // Durante il debug mostra le informazioni di profilo della grafica.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Visualizza i contatori di frequenza fotogrammi correnti.
                Application.Current.Host.Settings.EnableFrameRateCounter = true;

                // Mostra le aree dell'applicazione che vengono ridisegnate in ciascun frame.
                //Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Attiva la modalità di visualizzazine dell'analisi non di produzione, 
                // in cui una sovrapposizione colorata mostra le aree di una pagina sottoposte ad accelerazione GPU.
                //Application.Current.Host.Settings.EnableCacheVisualization = true;
            }

            // Inizializzazione Silverlight standard
            InitializeComponent();

            // Inizializzazione specifica per Phone
            InitializePhoneApplication();
        }

        // Codice da eseguire quando viene avviata l'applicazione (ad esempio da Start)
        // Questo codice non verrà eseguito quando l'applicazione viene riattivata
        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
        }

        // Codice da eseguire quando l'applicazione viene attivata (portata in primo piano)
        // Questo codice non verrà eseguito al primo avvio dell'applicazione
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
        }

        // Codice da eseguire quando l'applicazione viene disattivata (inviata in background)
        // Questo codicrrà eseguito quando l'applicazione viene chiusa
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
        }

        // Codice da eseguire quando l'applicazione viene chiusa (ad esempio se l'utente preme Indietro)
        // Questo codice non verrà eseguito quando l'applicazione viene disattivata
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
        }

        // Codice da eseguire in caso di passaggio a un'altra pagina non riuscito
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Passaggio a un'altra pagina non riuscito; passare al debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        // Codice da eseguire in caso di eccezioni non gestite
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Si è verificata un'eccezione non gestita; passare al debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        #region Inizializzazione applicazione Phone

        // Evita la doppia inizializzazione
        private bool phoneApplicationInitialized = false;

        // Non aggiungere alcun codice supplementare a questo metodo
        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized)
                return;

            // Crea il frame ma non impostarlo ancora come RootVisual; in questo modo
            // la schermata iniziale resta attiva finché l'applicazione non è pronta per il rendering.
            RootFrame = new PhoneApplicationFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            // Gestisci errori di passaggio
            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            // Evita la reinizializzazione
            phoneApplicationInitialized = true;
        }

        // Non aggiungere alcun codice supplementare a questo metodo
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Imposta l'elemento visivo radice in modo da consentire il rendering dell'applicazione
            if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            // Rimuovi questo gestore poiché non è più richiesto
            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }

        #endregion
    }
}