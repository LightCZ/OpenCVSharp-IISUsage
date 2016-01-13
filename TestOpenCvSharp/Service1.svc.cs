using OpenCvSharp.CPlusPlus;

namespace TestOpenCvSharp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void GetData()
        {
            var imPath = "D:\\PATHTOIMAGE\\Original.jpg";
            var image = Cv2.ImRead(imPath);
            var sift = new SIFT(100);
            KeyPoint[] keypoints;
            MatOfFloat descriptors = new MatOfFloat();
            sift.Run(image, null, out keypoints, descriptors);
        }
    }
}
