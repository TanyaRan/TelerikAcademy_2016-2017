function onBtnClick (event, args) {
  var mainWindow= window,
      browserName = mainWindow.navigator.appCodeName,
      isMozilla = browserName === "Mozilla";

  if (isMozilla) {
    alert("Yes");
  } else {
    alert("No");
  }
}

onBtnClick();