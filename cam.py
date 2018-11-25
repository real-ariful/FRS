import numpy as np
import cv2
from datetime import datetime
import time
from time import gmtime, strftime
import requests
import json

cap = cv2.VideoCapture(0)
number_of_frame = 10#10frames per second

while(True):
        dt = str(datetime.now())
        print("Start:" + dt)
        # Capture frame-by-frame
        ret, frame = cap.read()
        cv2.imshow('frame',frame)
        imgPath = "cam1/cam1.jpeg"
        cv2.imwrite(imgPath, frame)

        #Sending image and time to the PHP Server
                       
        url = 'http://localhost/frs2018/pages/admin/New folder (4)/save_image.php'
        files = {'image': open(imgPath, 'rb')}
        payload = {'datetime': dt}
        #timedate ={'datetime': dt}
        try: 
                response = requests.post(url, files=files, data=payload, timeout=5)
                print("Status code"+str(response.status_code))

        except requests.exceptions.RequestException as e:
                print("Error {}".format(e))
                print("Time out error")

        dt2 = str(datetime.now())
        #print(dt2-dt)
        print("End:" +dt2)
        dtsec = datetime.now().strftime("%S")
        print(dtsec)
        time.sleep(1/number_of_frame)

        if cv2.waitKey(1) & 0xFF == ord('q'):
                break

# When everything done, release the capture
cap.release()
cv2.destroyAllWindows()
