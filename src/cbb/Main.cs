namespace cbb
{
    using Autodesk.Revit.UI;
    using Autodesk.Revit.ApplicationServices;

    using ui;

    /// <summary>
    /// Pugin's main entry point.
    /// </summary>
    /// <seealso cref="Autodesk.Revit.UI.IExternalApplication" />
    public class Main : IExternalApplication
    {
        #region external application public methods

        /// <summary>
        /// Called when Revit starts up.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnStartup(UIControlledApplication application)
        {
            // Initialize whole plugin's user interface.
            var ui = new SetupInterface();
            ui.Initialize(application);

            application.ControlledApplication.ApplicationInitialized += DockablePaneRegisters;

            return Result.Succeeded;
        }

        /// <summary>
        /// Called when [Revit shutdown.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        #endregion

        #region private methods

        /// <summary>
        /// Register dockable panes in zero state document.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Autodesk.Revit.DB.Events.ApplicationInitializedEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void DockablePaneRegisters(object sender, Autodesk.Revit.DB.Events.ApplicationInitializedEventArgs e)
        {
            // Register dockable pane.
            var familyManagerRegisterCommand = new RegisterFamilyManagerCommand();
            familyManagerRegisterCommand.Execute(new UIApplication(sender as Application));
        }

        #endregion
    }
}
