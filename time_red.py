#Perform the function every thirty seconds


##import datetime
##now = datetime.datetime.now()
##datetime = now.strftime('%Y-%d-%m %H:%M:%f')
##print("Current datetime: "+ str(datetime))
##date = now.strftime('%Y-%d-%m')
##print("Todays date:"+str(date))
##
##
##from datetime import datetime
##now = str(now)
##print(now)
##
##s1 = str(bldatetime.strftime('%Y-%m-%d %H:%M:%S.%f'))
##FMT = '%Y-%m-%d %H:%M:%S.%f'
##fmt2= '%H:%M:%S.%f'
##tdelta = datetime.strptime(s2, FMT) - datetime.strptime(s1, FMT)
##print("Time Difference")
##print(tdelta)
##import datetime
##print(type(tdelta))
###Not working
##print(datetime.timedelta(seconds=30))
##if tdelta < datetime.timedelta(seconds=30):
##    print("Time smaller than 30 seconds")

#Defining the functions used for mysql query

#Importing the libraries
import mysql.connector
import time

#Creating a new function for values FROM `frs_blelogs`
def exnonefblelogs(date):

    #cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    #cursor = cnx.cursor()
    query = ("SELECT bleid, gatewayid, entrytime FROM `frs_blelogs` WHERE entrydate = '" + str(date) + "' AND exittime = 'None'")
    result = cursor.execute(query)
    blelog = cursor.fetchall()
    print("Query Result from blelogs-->")
    print(blelog)
    print(len(blelog))#Gives value 2-->[('aaa', 1, datetime.datetime(2018, 7, 11, 12, 24, 48)), ('bb', 1, datetime.datetime(2018, 7, 11, 15, 24, 48))]
    
    #cursor.close()
    #cnx.close()
    return blelog

#Creating a new function for datetime FROM `frs_blelocation`
def dtfblelocation(ble):
    
    #cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    #cursor = cnx.cursor()
    query = ("SELECT datetime FROM `frs_blelocation` WHERE bleuid = '" + str(ble[0]) + "' AND gatewayid = '"+ str(ble[1]) +"' AND SUBSTRING_INDEX(datetime,' ',1) = '"+ str(ble[2].strftime('%Y-%d-%m')) +"'")
    #print(query)
    result = cursor.execute(query)
    bleck = cursor.fetchall()
    return bleck

#Function to update exit time in blelogs
def etupblelogs(now, ble, date):

    print("Time greater than 2 minutes")
    print(ble[0])
    print(str(ble[0])+"is offlien and exit time must be updated")
    #! Does it must be removed from frs_blelocation or status given 0
    #Updating Exit Time for offline ble
    query = """ UPDATE frs_blelogs
                SET exittime=%s
                WHERE bleid=%s AND gatewayid=%s AND entrydate=%s AND exittime=%s"""             
    data = (str(now),str(ble[0]),str(ble[1]),str(date),'None')
    print("+++++++++++.")
    print(query,data)               
    cursor.execute(query, data)
    print(query)
    cnx.commit()

print("#--------")
#------------------------------------------------------------
while True:


    #Get present day and time
    import datetime 
    now = datetime.datetime.now()
    datetime = now.strftime('%Y-%d-%m %H:%M:%f')
    print("Current datetime: "+ str(datetime))
    date = now.strftime('%Y-%d-%m')
    print("Todays date:"+str(date))
    import mysql.connector

    cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    cursor = cnx.cursor()  

    try:
        #Tentative soln:
        #Take bleid and gtid,dt from blelogs where exittime == None and entrydate == today's date:
        exNone = exnonefblelogs(date)
        print(exNone)
        print("#--------")
        print("#############")
        #Go to each bleid:
        for ble in exNone:
            #Check in blelocation -->to each bleid in blelocation
            bleck = dtfblelocation(ble)
            print(bleck)
            print(len(bleck))

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
                print("#-------------#")
                print("blelocation datetime- "+str(bldatetime[0].strftime('%Y-%m-%d %H:%M:%S.%f')))#(datetime.datetime(2018, 11, 7, 21, 5),)
                print("Present datetime- "+str(now))
                print("#-------------#")
                
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

                    #print(ble[0])
                    print(str(ble[0])+"is Offline")               

                    #! Does it must be removed from frs_blelocation or status given 0
                    #Updating Exit Time for offline ble
                    query = """ UPDATE frs_blelogs
                                SET exittime=%s
                                WHERE bleid=%s AND gatewayid=%s AND entrydate=%s AND exittime=%s"""             
                    data = (str(now),str(ble[0]),str(ble[1]),str(date),'None')
                    #print("+++++++++++.")
                    #print(query,data)               
                    cursor.execute(query, data)
                    #print(query)
                    cnx.commit()
                    print("exit time must be updated")

        #Disconnecting the mysql server
        cursor.close()
        cnx.close()
        print("#############")
        time.sleep(2)

    except (MySQLdb.Error, MySQLdb.Warning) as e:
        print(e)
        #return None




        
###Tentative soln:
###Take bleid and gtid,dt from blelogs where exittime == None and entrydate == today's date:
##import mysql.connector
##cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
##cursor = cnx.cursor()
##query = ("SELECT bleid, gatewayid, entrytime FROM `frs_blelogs` WHERE entrydate = '" + str(date) + "' AND exittime = 'None'")
##result = cursor.execute(query)
##blelog = cursor.fetchall()
##print("Query Result from blelogs-->")
##print(blelog)
##print(len(blelog))#Gives value 2-->[('aaa', 1, datetime.datetime(2018, 7, 11, 12, 24, 48)), ('bb', 1, datetime.datetime(2018, 7, 11, 15, 24, 48))]
##                
###Go to each bleid:
##for ble in blelog:
##    #Check in blelocation -->to each bleid in blelocation
##    #print(ble)
##    #print("ble in blelog")
##    #print("Ble id :"+ str(ble[0]))
##    #print("GT id :"+ str(ble[1]))
##    #print("dt :"+ str(ble[2].strftime('%Y-%d-%m')))
##    #cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
##    #cursor = cnx.cursor()
##    #SELECT * FROM `frs_blelocation` WHERE bleuid = 'aaa' AND gatewayid = '1' AND SUBSTRING_INDEX(datetime,' ',1) = '2018-11-07'
##    query = ("SELECT datetime FROM `frs_blelocation` WHERE bleuid = '" + str(ble[0]) + "' AND gatewayid = '"+ str(ble[1]) +"' AND SUBSTRING_INDEX(datetime,' ',1) = '"+ str(ble[2].strftime('%Y-%d-%m')) +"'")
##    #print(query)
##    result = cursor.execute(query)
##    bleck = cursor.fetchall()
##    #print(bleck)
##    ctrow = len(bleck)
##    print("ctrow"+str(ctrow))
##    print(type(ctrow))
##    #print("..........")
##    if ctrow == 0:
##        print("ble is offline")
##    elif ctrow == 1:
##        #Compare gt and timediff
##        #if current time - blelocation datetime > certaintime:
##        #flag = +1
##
##        #print(str(bleck))#Can't convert 'datetime.datetime' object to str implicitly
##        bldatetime = bleck[0]
##
##        print(bleck[0])
##        print(bldatetime)#[(datetime.datetime(2018, 11, 7, 21, 5),)]
##        print("blelocation datetime- "+str(bldatetime[0].strftime('%Y-%m-%d %H:%M:%S.%f')))#(datetime.datetime(2018, 11, 7, 21, 5),)
##        print("Present datetime- "+str(now))
##        
##        print("Datetime from frs_blelocation-->")
##        print(bleck)
##
##
##        from datetime import datetime
##        s2 = str(now)
##        #print(s2)
##        bldatetime = bleck[0]
##
##        bldatetime = bleck[0][0]
##        #print(str(bldatetime))
##        #problem here
##
##        s1 = str(bldatetime.strftime('%Y-%m-%d %H:%M:%S.%f'))
##        FMT = '%Y-%m-%d %H:%M:%S.%f'
##        fmt2= '%H:%M:%S.%f'
##        tdelta = datetime.strptime(s2, FMT) - datetime.strptime(s1, FMT)
##        print("Time Difference")
##        print(tdelta)
##        import datetime
##        print(type(tdelta))
##        #Not working
##        print(datetime.timedelta(minutes=2))
##        if tdelta < datetime.timedelta(minutes=2):
##            print("Time smaller than 2 minutes")
##        elif tdelta >=datetime.timedelta(minutes=2):
##            print("Time greater than 2 minutes")
##
##            print(ble[0])
##            print(str(ble[0])+"is offlien and exit time must be updated")
##
##            #! Does it must be removed from frs_blelocation or status given 0
##            #Updating Exit Time for offline ble
##            query = """ UPDATE frs_blelogs
##                        SET exittime=%s
##                        WHERE bleid=%s AND gatewayid=%s AND entrydate=%s AND exittime=%s"""             
##            data = (str(now),str(ble[0]),str(ble[1]),str(date),'None')
##            print("+++++++++++.")
##            print(query,data)               
##            cursor.execute(query, data)
##            print(query)
##            cnx.commit()
##
##
##        #print("ble matches and online")
##    print()
### cursor.close()
### cnx.close()
##
##                    #if flag == 2:
##                        #(considered offline)
##                        #Update exit time for that ble in blelogs
##                
            
