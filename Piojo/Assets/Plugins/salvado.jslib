mergeInto(LibraryManager.library, {

  GuardarDatos: function (datos) {
    d=Pointer_stringify(datos);
    datos=JSON.stringify(d);
    window.localStorage.setItem("datos",d);
  },

  CargarDatos: function (str) {
    s=window.localStorage.getItem("datos");
    str=s;
    return str;
  }

});