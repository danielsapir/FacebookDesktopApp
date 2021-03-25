using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class PhotoBindingAdapter
    {
        public Photo PhotoAdoptee { get;  private set; }

        public string FullLocation { get; private set; }

        public PhotoBindingAdapter(Photo i_PhotoAdoptee)
        {
            PhotoAdoptee = i_PhotoAdoptee;
            FullLocation = i_PhotoAdoptee.Place.Location.City + ", " + i_PhotoAdoptee.Place.Location.Country;
        }
    }
}
