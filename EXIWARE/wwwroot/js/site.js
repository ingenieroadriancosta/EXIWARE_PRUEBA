// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ModalInfoShow( title, msg ){
    try{
        document.getElementById("shmod_MsgIS").click();
        document.getElementById("myModal_ModalMsgInfo_title").innerHTML = "" + title;
        document.getElementById("myModal_ModalMsgInfo_Msg").innerHTML = "" + msg;
        return document.getElementById("closemyModal_ModalMsgInfo_Msg");
    }catch{
    }
    var target = document.createElement("DIV");
    target.id = "ModalMsgInfo";
    document.body.appendChild(target);
    var str = '<div class="modal fade" id="myModal_ModalMsgInfo" tabindex="-1" role="dialog" data-keyboard="false" data-backdrop="static">' + 
'<input class="btn btn-default" type="button" data-toggle="modal" data-target="#myModal_ModalMsgInfo" value="" id="shmod_MsgIS"/>'+



'<div class="modal-dialog">'+
'<div class="modal-content">'+

'<div class="modal-header">'+
'<h4 class="modal-title" id="myModal_ModalMsgInfo_title">'+
'</h4>'+
/*
'<button type="button" class="close" data-dismiss="modal" aria-label="Close">'+
'          <span aria-hidden="true">&times;</span>'+
'        </button>'+
//*/
'</div>'+
    '<div class="modal-body">'+
    '<p id="myModal_ModalMsgInfo_Msg">Aquí va un texto.</p>'+
    '</div>'+
'<div class="modal-footer">'+
    '<button type="button" class="btn btn-primary" data-dismiss="modal" id="closemyModal_ModalMsgInfo_Msg" >Cerrar</button>'+
'</div>'+
'</div>'+
'</div>'+
'</div>'+
                '';
    var temp = document.createElement('div');
    temp.innerHTML = str;
    while (temp.firstChild) {
        target.appendChild(temp.firstChild);
    }
    document.getElementById("shmod_MsgIS").click();
    document.getElementById("myModal_ModalMsgInfo_title").innerHTML = "" + title;
    document.getElementById("myModal_ModalMsgInfo_Msg").innerHTML = "" + msg;
    return document.getElementById("closemyModal_ModalMsgInfo_Msg");
    
}



function senddatas( url, method, asyncv, datas ){
    var http = new XMLHttpRequest();
    http.open(method, url, asyncv);
    http.setRequestHeader('Content-type', 'application/json')
    /*
    http.onreadystatechange = function() {
        if( http.readyState!=4 ){
            return;
        }
        if(http.status == 200) {
            if( http.responseText.includes("Ok") ){
                ModalInfoShow( "Status", "Sesión iniciada, presiona cerrar para continuar" ).onclick = function(){location.reload();};
            }
        }else{
            ModalInfoShow( "Error!!!", http.responseText+"" ).onclick = function(){
                    location.reload();
            };
        }
    }
    //*/
    // http.send();
    http.send(datas)
    return http;
}