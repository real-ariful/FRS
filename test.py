bleid = "aaa"
gatewayid ="2"
import mysql.connector

#Check for bleid where date = today
import datetime

def bleidblelogs(bleid,gtid, date):
    cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    cursor = cnx.cursor()            
    query8= ("SELECT COUNT(*) FROM frs_blelogs WHERE bleid ='"+bleid+"'")
    result8 = cursor.execute(query8)
    #print("Query 2 result-->")
    #print(result2)
    tempvar8 = cursor.fetchone()
    print(tempvar8)
    rowcount = tempvar8[0]

    
    #Insert data into table frs_school if rowcount is 0
    if rowcount == 0:            
        query = ("INSERT INTO frs_blelogs (bleid,gatewayid,entrytime) VALUES(%s,%s,%s)",
                 (bleid,gatewayid,str(datetime)))
        cursor.execute(*query)
        cnx.commit()
        cursor.close()
        cnx.close()
        print("DATA INSERTED TO table frs_blelogs")

    #Update data into table frs_blelogs if rowcount>0
    if rowcount > 0:
        dttoday = datetime.split(" ")[0]
        print("rowcount greater than 0------------------")
        # prepare query and data
        cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
        cursor = cnx.cursor() 
        print("Today date is:"+dttoday)
        query9= ("SELECT * FROM frs_blelogs WHERE bleid ='"+str(bleid)+"' AND entrytime='"+str(dttoday)+"' AND gatewayid='"+str(gtid)+"'")   
        result9 = cursor.execute(query9)
        tempvar9 = cursor.fetchall()#list object
        print("Row Count in frs_blelogs is:" + str(tempvar9))
        if len(tempvar9)>0:
            for i in range(0,len(tempvar9)):
                #print(tempvar9[i])
                loginid = tempvar9[i][0]
                bleid = tempvar9[i][1]
                gatewayid = tempvar9[i][2]
                entrytime = tempvar9[i][3]
                endtime = tempvar9[i][4]
                print("Bleid-"+bleid)
                print("gatewayid-"+gatewayid)
                print("entrytime-"+entrytime)
                print("endtime-"+endtime)
                print("-------------Datetime is"+str(datetime))


        query10= ("SELECT COUNT(*) FROM frs_blelogs WHERE bleid ='"+str(bleid)+"' AND entrydate='"+str(dttoday)+"' AND gatewayid='"+str(gtid)+"'")   
        result10 = cursor.execute(query10)
        tempvar10 = cursor.fetchone()
        #print(tempvar10)
        cursor.close()
        cnx.close()

        rowct = tempvar10[0]
        print("Row count is: "+str(rowct))
        if rowct == 0:
            print("Different gateway")
            #Insert exittime in old gatewayid
            cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
            cursor = cnx.cursor()
            print("DATETIME:" + datetime)
            
            query12 = ("UPDATE frs_blelogs SET exittime ='"+str(datetime) +"' WHERE bleid ='"+str(bleid)+"' AND entrydate='"+str(dttoday)+"' AND gatewayid='"+str(gtid)+"'")
            cursor.execute(query12)
            cursor.close()
            cnx.close()

            #Insert entry for new gateway

            print(bleid)
            print(gtid)
            print(datetime)
            print(type(bleid))
            print(type(gtid))
            print(type(datetime))
            #SQL insertion when ble goes to another gateway

            cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
            cursor = cnx.cursor()                     
            query13= ("INSERT INTO frs_blelogs (bleid,gatewayid,entrydate,entrytime) VALUES(%s,%s,%s,%s)",(str(bleid),str(gtid),str(dttoday),str(datetime)))
            cursor.execute(*query13)
            print(query13)
            cnx.commit()
            cursor.close()
            cnx.close()
            print("Insert data successful")
        #print(tempvar9)
        #cnx.commit()         
        #cursor.close()
        #cnx.close()

now = datetime.datetime.now()
#print(now.microsecond)
datetime = now.strftime('%Y-%d-%m %H:%M:%S.000000')
print(datetime.split(" ")[0])
date = now.strftime('%Y-%d-%m')
day = now.strftime("%A")
print(date)
print(day)
timenow = now.strftime('%H:%M:%S')
print(timenow)

bleidblelogs(bleid,"1", datetime)

#Comparing two datetimes
datetime1 = now.strftime('%Y-%d-%m %H:%M:%S.000000')
datetime2 = "2018-06-11 13:35:00.000000"
##if datetime2 < datetime1:
##    print("datetime2 is smaller than datetime1")
##    #diff = datetime1-datetime2#Cannot use this
##    print(diff)



    

##    #print("Studentid-->tempvar[0]-->"+str(sid))
##    if  tempvar8[0] == None:
##        print("Result2:")
##        print(tempvar2[0])
##    if  tempvar8[0] != None:
##        sid = tempvar8[0]#gives 1
##        #print("Student id of student is" + str(sid))
##    return sid
