mergeInto(LibraryManager.library, {

  GuardarDatos: function (datos) {
    d=Pointer_stringify(datos);
    datos=JSON.stringify(d);
    window.localStorage.setItem('datos',d);
  },

  CargarDatos: function () {
    try{
    s=window.localStorage.getItem('datos');
    
    var bufferSize = lengthBytesUTF8(s) + 1;
   var buffer = _malloc(bufferSize);
   stringToUTF8(s, buffer, bufferSize);
   return buffer;
    }catch(e){
      return null;
    }
    
  }

});