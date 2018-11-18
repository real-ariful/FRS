from datetime import datetime
s1 = '2018-11-06 15:00:17.910270'
s2 = '2018-11-06 15:05:17.001222' # for example
FMT = '%Y-%d-%m %H:%M:%S.%f'
fmt2= '%H:%M:%S.%f'
tdelta = datetime.strptime(s2, FMT) - datetime.strptime(s1, FMT)
print("Time Difference")
print(tdelta)
import datetime
print(type(tdelta))
#Not working
print(datetime.timedelta(minutes=2))
if tdelta < datetime.timedelta(minutes=2):
    print("Time smaller than 2 minutes")
elif tdelta >=datetime.timedelta(minutes=2):
    print("Time greater than 2 minutes")

#----------------------------------------------------    
##from datetime import datetime
##print(datetime.strptime(s2, FMT))
##
##import datetime
##now = datetime.datetime.now()
##print(now)
##date = now.strftime('%Y-%m-%d %H:%M:%S.%f')[:0]
##print(date)
##day = now.strftime("%A")
##timenow = now.strftime('%H:%M:%S.%S')


#----------------------
##import datetime
##current_time = datetime.datetime(2011,12,12,12,0,0) # High Noon!
##end_time = datetime.datetime(2011,12,25,0,0,0)      # Santa?
##if end_time-current_time > datetime.timedelta(0):
##    #do_stuff()
##    current_time = current_time - datetime.timedelta(hours=1)
##    print(current_time)

import mysql.connector
cnx3 = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
cursor3 = cnx3.cursor()            
query3= ("SELECT bleuid,gatewayid,datetime FROM frs_blelocation WHERE datetime='2018-11-06'")
result3 = cursor3.execute(query3)
tempvar3 = cursor3.fetchall()
print("Query Result-->")
print(tempvar3)#gives(room,)

on_bleid=[]

for i in range(0,len(tempvar3)):
    bleuid = tempvar3[i][0]
    gatewayid = tempvar3[i][1]
    datetime = tempvar3[i][2]
    print(bleuid)
    print(gatewayid)
    print(datetime)
    on_bleid.append([bleuid,gatewayid,datetime])
print("Online BLE from database: "+str(on_bleid))
    


#on_bleid = ["a","c","e"]
bleingwy = {"bleingwy": [
            {"gid":"1",
             "bid": ["a","b","c"],
             "dtime": ["2018-11-06 12:05:17.001222","2018-11-06 15:05:17.001222","2018-11-06 17:05:17.001222"]             
             },
            {"gid":"2",
             "bid": ["d","aaa","f"],
             "dtime": ["2018-11-06 12:10:17.001222","2018-11-06 11:05:17.001222","2018-11-06 10:05:17.001222"]
             }
            ]}
#print(bleingwy)
print(type(bleingwy))
print(bleingwy["bleingwy"])


for i in bleingwy["bleingwy"]:
    print("ble in: "+i["gid"])
    print(i)
    print(i["bid"])
    for j in i["bid"]:
        print(j)
        for k in on_bleid:
            if j == k[0] and i["gid"] == k[1]:
                print("Similar ble")#Means this ble is online



#Function to periodically check the bles without exittime for being offline
#When ble goes offline or out of range from the last gateway
#Need to fill exit time or blelogs but how to find non-active ble

#Get present day and time
import datetime 
now = datetime.datetime.now()
#print(now.microsecond)
datetime = now.strftime('%Y-%d-%m %H:%M:%S.000000')
print("Current datetime:"+ str(datetime))
#print(datetime.split(" ")[0])
date = now.strftime('%Y-%d-%m')
#day = now.strftime("%A")
print("Todays date:"+str(date))
#print(day)
#timenow = now.strftime('%H:%M:%S')
#print(timenow)


#Tentative soln:
#Take bleid and gtid,dt from blelogs where exittime == None and entrydate == today's date:
import mysql.connector
cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
cursor = cnx.cursor()
query = ("SELECT bleid, gatewayid, entrytime FROM `frs_blelogs` WHERE entrydate = '" + str(date) + "' AND exittime = 'None'")
#query= ("SELECT bleid,entrytime FROM frs_blelogs WHERE entrydate='2018-11-07' and exittime = 'None'")
result = cursor.execute(query)
blelog = cursor.fetchall()
print("Query Result from blelogs-->")
print(blelog)
print(len(blelog))#Gives value 2-->[('aaa', 1, datetime.datetime(2018, 7, 11, 12, 24, 48)), ('bb', 1, datetime.datetime(2018, 7, 11, 15, 24, 48))]
                
#Go to each bleid:
for ble in blelog:
    #Check in blelocation -->to each bleid in blelocation
    #print(ble)
    print("ble in blelog")
    print("Ble id :"+ str(ble[0]))
    print("GT id :"+ str(ble[1]))
    print("dt :"+ str(ble[2].strftime('%Y-%d-%m')))
    #cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    #cursor = cnx.cursor()
    #SELECT * FROM `frs_blelocation` WHERE bleuid = 'aaa' AND gatewayid = '1' AND SUBSTRING_INDEX(datetime,' ',1) = '2018-11-07'
    query = ("SELECT datetime FROM `frs_blelocation` WHERE bleuid = '" + str(ble[0]) + "' AND gatewayid = '"+ str(ble[1]) +"' AND SUBSTRING_INDEX(datetime,' ',1) = '"+ str(ble[2].strftime('%Y-%d-%m')) +"'")
    #print(query)
    result = cursor.execute(query)
    bleck = cursor.fetchall()
    #print(bleck)
    ctrow = len(bleck)
    print("ctrow"+str(ctrow))
    print(type(ctrow))
    #print("..........")
    if ctrow == 0:
        print("ble is offline")
    elif ctrow == 1:
        #Compare gt and timediff
        #if current time - blelocation datetime > certaintime:
        #flag = +1

        #print(str(bleck))#Can't convert 'datetime.datetime' object to str implicitly
        bldatetime = bleck[0]

        print(bleck[0])
        print(bldatetime)#[(datetime.datetime(2018, 11, 7, 21, 5),)]
        print("blelocation datetime- "+str(bldatetime[0].strftime('%Y-%m-%d %H:%M:%S.%f')))#(datetime.datetime(2018, 11, 7, 21, 5),)
        print("Present datetime- "+str(now))
        
        print("Datetime from frs_blelocation-->")
        print(bleck)


        from datetime import datetime
        s2 = str(now)
        #print(s2)
        bldatetime = bleck[0]

        bldatetime = bleck[0][0]
        #print(str(bldatetime))
        #problem here

        s1 = str(bldatetime.strftime('%Y-%m-%d %H:%M:%S.%f'))
        FMT = '%Y-%m-%d %H:%M:%S.%f'
        fmt2= '%H:%M:%S.%f'
        tdelta = datetime.strptime(s2, FMT) - datetime.strptime(s1, FMT)
        print("Time Difference")
        print(tdelta)
        import datetime
        print(type(tdelta))
        #Not working
        print(datetime.timedelta(minutes=2))
        if tdelta < datetime.timedelta(minutes=2):
            print("Time smaller than 2 minutes")
        elif tdelta >=datetime.timedelta(minutes=2):
            print("Time greater than 2 minutes")

            print(ble[0])
            print(str(ble[0])+"is offlien and exit time must be updated")

            #! Does it must be removed from frs_blelocation or status given 0
            #Updating Exit Time for offline ble

            #cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
            #cursor = cnx.cursor()
                # prepare query and data
            query = """ UPDATE frs_blelogs
                        SET exittime=%s
                        WHERE bleid=%s AND gatewayid=%s AND entrydate=%s AND exittime=%s"""             
            data = (str(now),str(ble[0]),str(ble[1]),str(date),'None')
            print("+++++++++++.")
            print(query,data)               
            cursor.execute(query, data)
            print(query)
            cnx.commit()


        #print("ble matches and online")
    print()
# cursor.close()
# cnx.close()

                    #if flag == 2:
                        #(considered offline)
                        #Update exit time for that ble in blelogs
                
            
