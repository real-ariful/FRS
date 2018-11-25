<?php
$info = pathinfo($_FILES['image']['name']);
$ext = $info['extension'];//get the extension of the file
$newname ='new_image.'.$ext;//new name of image
$target ='image/'.$newname;
move_uploaded_file($_FILES["image"]["tmp_name"], $target);


//Write the text file

$myfile = fopen("../../../db/cameras/cam1/cam1.txt", "w") or die("Unable to open file!");
$firstname = htmlspecialchars($_POST["datetime"]);
$txt = "datetimeee: ". $firstname;
fwrite($myfile, $txt);
//$txt = "Jane Doe\n";
//fwrite($myfile, $txt);
fclose($myfile);
?>