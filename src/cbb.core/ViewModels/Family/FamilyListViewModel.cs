namespace cbb.core
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// A view model for list of the family items.
    /// </summary>
    /// <seealso cref="cbb.core.BaseViewModel" />
    public class FamilyListViewModel : BaseViewModel
    {
        #region private members

        /// <summary>
        /// The path list to directories with items.
        /// todo implement in preferences system for chosing directori locations.
        /// Here are some folders with Revit family and project items.
        /// </summary>
        private List<string> mPaths = new List<string>
        {
            @"C:\Users\marko\Documents\_development_\familyBrowsing1",
            @"C:\Users\marko\Documents\_development_\Dvorana",
        };

        #endregion

        #region public properties

        /// <summary>
        /// Gets or sets the items for the list view.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public ObservableCollection<FamilyItem> Items { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="FamilyListViewModel"/> class.
        /// </summary>
        public FamilyListViewModel()
        {
            // Populate Items list for list control.
            Items = Populate(mPaths);
        }

        #endregion

        #region private methods

        /// <summary>
        /// Populates the list with items from provided folder paths.
        /// </summary>
        /// <param name="paths">The paths.</param>
        /// <returns></returns>
        private ObservableCollection<FamilyItem> Populate(List<string> paths)
        {
            var items = new ObservableCollection<FamilyItem>();

            foreach (var path in paths)
            {
                // Get family items from repository.
                var children = FamilyList.GetItems(path);

                // Add them to collection.
                foreach (var child in children)
                    items.Add(child);
            }

            return items;
        }

        #endregion
    }
}
