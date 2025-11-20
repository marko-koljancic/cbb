namespace cbb.core
{
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Gets the items from the repository.
    /// </summary>
    public static class FamilyList
    {
        #region public methods

        /// <summary>
        /// Gets the items from the repository.
        /// </summary>
        /// <param name="path">The path to repository directory.</param>
        /// <returns></returns>
        public static List<FamilyItem> GetItems(string path)
        {
            var items = new List<FamilyItem>();

            try
            {
                var fs = Directory.GetFiles(path);

                // Check if directory has file items.
                // Cast file items to the more specific FamilyItem.
                if (fs.Length > 0)
                    items.AddRange(fs.Select(file => new FamilyItem { FullPath = file }));
            }
            catch { }

            return items;
        }

        #endregion
    }
}
