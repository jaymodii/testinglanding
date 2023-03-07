var gridrows=document.querySelectorAll(".gridrow");
var listcards=document.querySelectorAll(".listcard")
var cards=document.querySelectorAll(".card");

function listview() {
    
    for (var i=0; i<gridrows.length;i++){
    gridrows[i].style.display="none";
    }
    for(var i=0; i<listcards.length;i++){
    listcards[i].style.display="flex";
    }

}

function gridview(){
    for (var i=0; i<gridrows.length;i++){
        gridrows[i].style.display="flex";
        }
    for (var i = 0; i < listcards.length; i++){
            listcards[i].style.display="none";
            }

}
// function autoswitch(nondesktop){
//     if(nondesktop.matches){
//         function gridview()
//     }

// }

function deletehistory() {

    var obj = document.getElementById("history")
    console.log(obj)
    obj.style.display="none";
}