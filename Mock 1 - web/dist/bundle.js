!function(e){var n={};function t(r){if(n[r])return n[r].exports;var o=n[r]={i:r,l:!1,exports:{}};return e[r].call(o.exports,o,o.exports,t),o.l=!0,o.exports}t.m=e,t.c=n,t.d=function(e,n,r){t.o(e,n)||Object.defineProperty(e,n,{enumerable:!0,get:r})},t.r=function(e){"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},t.t=function(e,n){if(1&n&&(e=t(e)),8&n)return e;if(4&n&&"object"==typeof e&&e&&e.__esModule)return e;var r=Object.create(null);if(t.r(r),Object.defineProperty(r,"default",{enumerable:!0,value:e}),2&n&&"string"!=typeof e)for(var o in e)t.d(r,o,function(n){return e[n]}.bind(null,o));return r},t.n=function(e){var n=e&&e.__esModule?function(){return e.default}:function(){return e};return t.d(n,"a",n),n},t.o=function(e,n){return Object.prototype.hasOwnProperty.call(e,n)},t.p="/dist/",t(t.s=0)}([function(e,n,t){t(1),t(2),e.exports=t(3)},function(e,n,t){e.exports=t.p+"index.htm"},function(e,n,t){e.exports=t.p+"bundle.css"},function(e,n){document.getElementById("btn_submit").addEventListener("click",(function(){var e=document.getElementById("car_price");console.log("input from user:"+e.value);var n=e.value;console.log("input from user:"+e.value);var t=!isNaN(+n);console.log("bool: "+t);var r=document.getElementById("car_type"),o=r.selectedIndex,u=(r.options[o],+n);t?(console.log("drp: "+o),0==o&&function(e){var n=.85;e>2e5?(n=1.5,!0):(n=.85,!1);var t=e*n;document.getElementById("feedback").innerHTML="bilens fulde afgift er: "+t+" kr",console.log("bil afgift er: "+t+" kr")}(u),1==o&&function(e){var n=.85;e>2e5?(n=1.5,!0):(n=.85,!1);var t=e*n-13e4;document.getElementById("feedback").innerHTML="bilens fulde afgift er: "+t+" kr",console.log("bil afgift er: "+t+" kr")}(u)):(document.getElementById("feedback").innerHTML="den indtastet pris er ikke brugbar.",console.log("den indtastet pris er ikke brugbar."))}));var t=document.getElementById("car_price");console.log("input from user:"+t.value);var r=t.value;console.log("input converted to number:"+r)}]);
//# sourceMappingURL=bundle.js.map