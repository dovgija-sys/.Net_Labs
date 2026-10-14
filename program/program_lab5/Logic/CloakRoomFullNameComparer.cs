namespace program_lab5.Logic
{
    public class CloakRoomFullNameComparer : IComparer<CloakRoom>
    {
        public int Compare(CloakRoom? cloakRoom1, CloakRoom? cloakRoom2)
        {
            if (cloakRoom1 == null || cloakRoom2 == null)
            {
                return 0;
            }
            return string.Compare(cloakRoom1.FullName, cloakRoom2.FullName, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
