<?php
$match_details=$obj_app->select_last_fivefaces_info($_GET);
 //$match_info = mysqli_fetch_assoc($match_details);
// echo gettype($match_info);
// echo count($match_info);
// $items = array_slice($match_details, -5);
//  echo count($match_info);
?>

<!--  Addition-->


<!-- End Addition -->
<!-- Content Header (Page header) -->

<!-- Script -->

<!-- End Script -->

    <section class="content-header">
      <h1>
        Camera Dashboard
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Video Management</a></li>
        <li class="active">Camera Dashboard</li>
      </ol>
    </section>


<!-- <body onload="JavaScript:timedRefresh(1000);"> -->
    <!-- Main content -->
    <section class="content">

         
      
      <!-- Main row -->
      <div class="row">
        <!-- Left col -->
        <section class="col-lg-8 col-md-8 col-xs-12" connectedSortable">
          
          <!-- Horizontal Form -->
          <div class="box box-info">
            <div class="box-header with-border">
              <h3 class="box-title">Camera Dashboard Details</h3>
            
            <!-- /.box-header -->
            <!-- form start -->
            <div class="row">
              <div id="refresh" class="col-lg-6 col-md-4 col-xs-12">                
                  <label for="camera1">Camera New</label>

                  <IMG src="frs2018\db\cameras\cam1\cam1.jpeg" border="1" name="refresh" alt="Girl in a jacket" width="320" height="240"> 
                  <SCRIPT language="JavaScript" type="text/javascript"> 
                  var t = 20 // Interval in Seconds
                  image = "/frs2018/pages/admin/New folder (4)/image/new_image.jpeg" //URL of the Image 
                  function Start() { 
                  tmp = new Date(); 
                  tmp = "?"+tmp.getTime() 
                  document.images["refresh"].src = image+tmp 
                  setTimeout("Start()", t) 
                  } 
                  Start(); 
                  </SCRIPT> 
                </div>


<!--                   <img id="x" src="\frs2018\pages\admin\New folder (4)\image\new_image.jpeg?c=0" alt="Girl in a jacket" width="320" height="240"> --> 
             
                  <!-- New addition -->

                  <!-- <body onload="JavaScript:timedRefresh(1000);"> -->


<!-- <canvas id="x" width="320" height="240" />
 <img id="x" src="\frs2018\pages\admin\New folder (4)\image\new_image.jpeg" alt="Girl in a jacket" width="320" height="240"> 
<script type="text/JavaScript">

var x=0, y=0;
var canvas, context, img;
var imgPath = "/frs2018/pages/admin/New folder (4)/image/new_image.jpeg";

function timedRefresh(timeoutPeriod)
{
    canvas = document.getElementById("newimage");
    context = canvas.getContext("2d");
    img = new Image();
    img.src = imgPath;
    context.drawImage(img, x, y);
    //x+=20; y+=20;
    //img.destroy();
    img.src =  imageURI + '?d=' + Date.now();
    setTimeout("timedRefresh(1000)",timeoutPeriod);
                              // just change src attribute, will always trigger the onload callback
                          
}

</script> -->


<!--                   <img id="x" src="\frs2018\pages\admin\New folder (4)\image2.jpeg" alt="Girl in a jacket" width="320" height="240">
                  <script type="text/javascript">
                    repImage("frs2018/pages/admin/New folder (4)/image2.jpeg" ,x);
                  </script> -->
                  <!-- <body onload="JavaScript:timedRefresh(1000);"> -->
                  <!-- <img id="x" src="\frs2018\pages\admin\New folder (4)\image2.jpeg" alt="Girl in a jacket" width="320" height="240"> -->
                  <!-- <img id="x" src="\New folder (4)\image.jpeg" width="320" height="240"> -->
                  <!-- <canvas onload="JavaScript:timedRefresh(1000);" id="x" width="320" height="240" style="border:1px solid #000000;"/> /frs2018/pages/admin/New folder (4)/image2.jpeg' -->
          
<!--             <canvas id="myCanvas" width="320" height="240"
            onload="imgChange('C:/xampp/htdocs/frs2018/pages/admin/New folder (4)/image2.jpeg')" style="border:1px solid #c3c3c3;">
                        Your browser does not support the canvas element.
                        </canvas>
                    <script type="text/javascript">
                    function imgChange(imagePath) {
                                var c=document.getElementById("myCanvas");
                                var ctx=c.getContext("2d");
                                var img=new Image();
                                img.onload = function(){
                                      ctx.drawImage(img,0,0);
                                };
                                img.src=imagePath;}
        </script> -->


                   <!-- </body>  -->


					<!-- Ends here -->
                  <!-- <video width="320" height="240" autoplay="autoplay">
                  <source src="http://192.168.0.109:8080/"></video> -->
              </div> 

              <div class="col-lg-6 col-md-4 col-xs-12">                
                  <label for="camera1">Camera 2</label>
                  <video width="320" height="240" autoplay="autoplay">
                  <source src="http://192.168.0.109:8081/">
                  </video>
              </div>

              <div class="col-lg-6 col-md-4 col-xs-12">                
                  <label for="camera1">Camera 3</label>
                  <video width="320" height="240" autoplay="autoplay">
                  <source src=""></video>
              </div>

              <div class="col-lg-6 col-md-4 col-xs-12">                
                  <label for="camera1">Camera 4</label>
                  <video width="320" height="240" autoplay="autoplay">
                  <source src=""></video>
              </div>           
          <!-- /.box -->
            </div>

         </section>      
        <!-- Left col -->

        <section class="col-lg-4 col-md-8 col-xs-12" connectedSortable">
            <div class="box box-info">
              <div class="box-header with-border">                 
                  <h3 class="box-title">Identification Details</h3>
              </div>
           <div class="box-body">
              <table id="example1" class="table table-bordered table-striped">



                <tbody>
                  <tr>
                <!--     <th>ID</th>
                    <th>Time</th> -->
                    <th>Cropped Image</th>
                    <th>Matched Name</th>
                    <th>Score</th>
                <!--     <th>Image_name</th> -->
                  </tr>

                  <?php while ($match_info = mysqli_fetch_assoc($match_details)) { ?>
                     <!-- $imgsrc = "./db/match/crop/".$match_info['id']; -->

                   <tr>   
                      <!-- <td><?php echo $match_info['id']; ?></td> -->
                <!--       <td><?php echo $match_info['time']; ?></td> -->
                      <td><img src="<?php echo $match_info['croped_image'] ; ?>" height="50" width="50"></td>
                      <td><?php echo $match_info['name']; ?></td>
                      <td><?php echo $match_info['score']; ?></td>
                <!--       <td><?php echo $match_info['Image_name']; ?></td> -->
                    </tr>

                  <?php } ?>
                </tbody>
              </table>
            </div>





            </div>
        </section>
      </div>

<!-- 
                         <script type="text/JavaScript"> -->


                     <!--   var x=0, y=0;
                      var img = new Image();
                      img.onload = function() {
                          var canvas = document.getElementById("x");
                          var context = canvas.getContext("2d");

                          context.drawImage(img, x, y);
                          //x+=20; y+=20;
                          setTimeout(timedRefresh,timeoutPeriod);
                      };

                      function timedRefresh() {
                          // just change src attribute, will always trigger the onload callback
                          img.src =  imageURI + '?d=' + Date.now();
                      }
                    </script> -->

<!--                     <script type="text/javascript">
                                            var timeoutPeriod = 1000;
                      var imageURI = '/frs2018/pages/admin/New folder (4)/image2.jpeg';
                      function repImage(imagePath, element){
                        var canvas = document.getElementById(element);
                        var context = canvas.getContext("2d");
                        context.drawImage(img, 0, 0);
                         setTimeout(timedRefresh,timeoutPeriod);
                      };

                      function timedRefresh() {
                          // just change src attribute, will always trigger the onload callback
                          img.src =  imageURI + '?d=' + Date.now();
                      }

                      
                    </script> -->

<!-- </body> -->