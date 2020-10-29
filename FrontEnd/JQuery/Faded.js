$(document).ready(function(){
    $("tr:even").css("background-color", "yellow");
    $("tr:odd").css("background-color", "red");  
    $("#button1").click(function(){
      $("tr:odd").fadeOut(3000);
    }) ;
    $("#button2").click(function(){
      $("tr:odd").fadeIn(1000);
    }) ;  
    $("#button3").click(function(){
        $("tr:odd").fadeToggle(1000);
      }) ;  
  });  