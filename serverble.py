#------------------------------School Security Project-------------------------------------------------------------------
#-----This code is used for data collecting from BLE server and saving on mysql server----------------------------------

#Importing libraries
from socket import AF_INET, socket, SOCK_STREAM
from threading import Thread
import pandas as pd
from datetime import date, datetime, timedelta
import mysql.connector
import datetime
import json

"""Sets up handling for incoming clients."""
def accept_incoming_connections():    
    while True:
        client, client_address = SERVER.accept()
        print("%s:%s has connected." % client_address)
        #client.send(bytes("Greetings from the server. you are connected now", "utf8"))
        addresses[client] = client_address
        Thread(target=handle_client, args=(client,client_address,)).start()

"""Handles a single client connection."""
def handle_client(client, client_address):
    name, x = client_address
    name = str(name)+ " "+ str(x)
    #welcome = 'Welcome %s! If you ever want to quit, type {quit} to exit.' % str(name)
    #client.send(bytes(welcome, "utf8"))
    msg = "%s has joined the server!" % str(name)
    #broadcast(bytes(msg, "utf8"))
    clients[client] = client_address
    while True:
        msg = client.recv(BUFSIZ)
        now = datetime.datetime.now()
        date = now.strftime('%Y-%m-%d %H:%M:%S')
        day = now.strftime("%A")
        timenow = now.strftime('%H:%M:%S.%S')
        msg = msg.decode("utf-8")
        #print(msg)
        #print(type(msg))#'str'

        msgjson = msg.replace("'", "\"")
        msgdict =json.loads(msgjson)
        print(type(msgdict))
        print(msgdict["bleid"])

        gwid = msgdict["gatewayid"]
        bleid = msgdict["bleid"]
        temp = msgdict["temp"]
        rssi = msgdict["rssi"]
        
        

        #Write data to text file
        data2txt(date,msg)
        

#         if msg != bytes("{quit}", "utf8"):
#             now = datetime.datetime.now()
#             date = now.strftime('%Y-%m-%d %H:%M:%S')
#             day = now.strftime("%A")
#             timenow = now.strftime('%H:%M:%S.%S')
#             msg = msg.decode("utf-8")
#             print("DATA Received from client-"+name+":" + msg)
#             gatewayid = msg.split('_')[0]
#             bleid = msg.split('_')[1]
#             rssi = msg.split('_')[2]
#             ble_location = rssi = msg.split('_')[3]
#             distance = rssi = msg.split('_')[4]

#             print(bleid)
# ##            print(gatewayid)
# ##            print(type(bleid))
# ##            print(rssi)
# ##            print(ble_location)
# ##            print(distance)

#             #Checking input for bleid in db table frs_school for today's date
#             cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
#             cursor = cnx.cursor()            
#             script1= ("SELECT COUNT(*) FROM frs_blelocation WHERE bleuid ='" + bleid + "'")

            
#             result = cursor.execute(script1)
#             tempvar = cursor.fetchone()
#             #print(tempvar)#gives(1,)
#             #print("Type tempvar-->"+str(tempvar)+ "-->" +str(type(tempvar)))
#             rowcount = tempvar[0]#gives 1
#             #print("Type tempvar[0]-->" + str(tempvar) +"-->"+str(type(tempvar[0])))
#             #print("Count result:" + str(int(rowcount)))


#             #Insert data into table frs_school if rowcount is 0
#             if rowcount == 0:            
#                 query = ("INSERT INTO frs_blelocation (bleuid,gatewayid,datetime,rssi,ble_location,distance)VALUES(%s,%s,%s,%s,%s,%s)",
#                          (bleid,gatewayid,str(datetime),rssi,ble_location,distance))
#                 cursor.execute(*query)
#                 cnx.commit()
#                 cursor.close()
#                 cnx.close()
#                 print("DATA INSERTED TO table frs_blelocation")

#             #Update data into table frs_school if rowcount>0
#             if rowcount > 0:
#                 print("rowcount greater than 0------------------")
#                 # prepare query and data
#                 query = """ UPDATE frs_blelocation
#                             SET gatewayid=%s,datetime=%s,rssi=%s,ble_location=%s,distance =%s
#                             WHERE bleuid=%s"""             
#                 data = (gatewayid,str(datetime),rssi,ble_location,distance,bleid)                
#                 cursor.execute(query, data)
#                 cnx.commit()         
#                 cursor.close()
#                 cnx.close()
#         else:
#             client.close()
#             del clients[client]
#             break
#         #print(bleid)
#         studentid = sidfrombleid(bleid)
#         print("Student id of student is" + str(studentid))

#         roomno = rnofromgtw(gatewayid)
#         print("Room no of student is" + str(roomno))

#         course_id = crsfromdtday(date, day, roomno, timenow)
#         if course_id != None:
#             print("Course of student is" + str(course_id))

#             match = crsmatchmdsid(studentid, course_id)
#             if match > 0:
#                 print("Match is: " + str(match))
#                 print("Student id:"+str(studentid)+"in roomno:"+str(roomno)+"has Course:"+course_id)
        
"""Function writing to text files"""
def data2txt(date,msg):
    try:
        f = open('serverble.txt','a')
        f.write(str(date)+": "+str(msg)+"\n")
        f.close()
        print("Data written to txt files")
    except Exception as e:
        raise e
        print("Error in data writing to text file")


"""Function getting from bleid to studentid"""
def sidfrombleid(bleid):
    cnx = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    cursor = cnx.cursor()            
    query2= ("SELECT student_id FROM frs_ble WHERE bleuid ='"+bleid+"'")
    result2 = cursor.execute(query2)
    #print("Query 2 result-->")
    #print(result2)
    tempvar2 = cursor.fetchone()
    #print(tempvar2)#gives(studentid,)
    

    #print("Studentid-->tempvar[0]-->"+str(sid))
    if  tempvar2[0] == None:
        print("Result2:")
        #print(tempvar2[0])
    if  tempvar2[0] != None:
        sid = tempvar2[0]#gives 1
        #print("Student id of student is" + str(sid))
    return sid


"""Function getting Room Number from gatewayid"""
def rnofromgtw(gatewayid):
    cnx3 = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    cursor3 = cnx3.cursor()            
    query3= ("SELECT room FROM frs_blegateway WHERE gatewayid ='"+gatewayid+"'")
    result3 = cursor3.execute(query3)
    tempvar3 = cursor3.fetchone()
    #print(tempvar3)#gives(room,)
    
    room = tempvar3[0]#gives 1
    #print("room-->tempvar[0]-->"+str(room))
    if  tempvar3[0] == None:
        print("No room found")
    if  tempvar3[0] != None:
        room = tempvar3[0]
    return room

"""Function checks if student has that course"""
"""Function getting Course Number from frs_classtable"""

def crsfromdtday(date, day, roomno,timenow):
    cnx4 = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    cursor4 = cnx4.cursor()

    #need to remove later----
    #day = 'Sunday'
    #timenow = "10:00:00.000000"
    #--------------
    print(day)
    print(roomno)    
    print(timenow)

    query4 = ("SELECT course_id FROM frs_classtable WHERE day ='" + day + "' AND room_no='" + roomno + "' AND '" +
                 timenow + "'>=class_start AND '" + timenow + "'<class_end")
    #print(query4)
    result4 = cursor4.execute(query4)
    #print(result4)
    course_id = None
    tempvar4 = cursor4.fetchone()
    print("tempvar4 is:"+ str(tempvar4))
    if tempvar4 != None:
        course_id = tempvar4[0]
    return course_id
            

"""Function matchibf Course Number with studentid in studentclasstable"""
def crsmatchmdsid(sid, course_id):
    cnx5 = mysql.connector.connect(host='127.0.0.1',user='root', password="", database='frs_school')
    cursor5 = cnx5.cursor()
    #script1= ("SELECT COUNT(*) FROM frs_blelocation WHERE bleuid ='"+bleid+"'")
    query5 = ("SELECT COUNT(*) FROM frs_studentcourses WHERE student_id='" + str(sid) + "' AND course_id='" + str(course_id) +"'")
    #print(query5)
    result5 = cursor5.execute(query5)
    #print(result5)
    tempvar5 = cursor5.fetchone()
    match = tempvar5[0]
    return match

def broadcast(msg, prefix=""):  # prefix is for name identification.
    """Broadcasts a message to all the clients."""

    for sock in clients:
        #print(sock)
        sock.send(bytes(prefix, "utf8")+msg)

        
clients = {}
addresses = {}

HOST = ''
PORT = 33000
BUFSIZ = 1024
ADDR = (HOST, PORT)


SERVER = socket(AF_INET, SOCK_STREAM)
SERVER.bind(ADDR)

if __name__ == "__main__":
    SERVER.listen(5)
    print("Waiting for connection...")
    ACCEPT_THREAD = Thread(target=accept_incoming_connections)
    ACCEPT_THREAD.start()
    ACCEPT_THREAD.join()
    SERVER.close()
