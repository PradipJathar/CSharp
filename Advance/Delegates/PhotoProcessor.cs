using System;

namespace Delegates
{
    // Delegates
    // A delegate is a reference type variable that holds the reference to a methods.
    // An object that used to call a method or a group of methods.
    // Used for designing extensible and flexible applications.
    // It use just like Interfaces, but used when caller doesn't need to access other properties or methods on the object implementing the method.

    public class PhotoProcessor
    {

        // 1] User defined delegate.
        public delegate void PhotoFilterHandler(Photo photo);       // Delegate

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }


        // 2] .Net predefined delegates.
        //    A. System.Action<T>  --> void
        //    B. System.Func<T>    --> return value

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

    }
}
