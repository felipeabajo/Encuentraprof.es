namespace BlazorServerSQLite.Shared
{
    public class MyStateContainer
    {
        public bool collapseNavMenu = true;
        public event Action OnStateChange;

        public void SetCollapseNavMenu(bool collapseNavMenu)
        {
            this.collapseNavMenu = collapseNavMenu;
            NotifyStateChanged();
        }
        private void NotifyStateChanged()
        {
            try { OnStateChange?.Invoke(); }
            catch (Exception) {
                //throw; 
            }
        }
    }
}
