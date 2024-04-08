
window.scrollToBottom = function () {
    var chatContainer = document.getElementById('chatContainer');
    chatContainer.scrollTop = chatContainer.scrollHeight;
};

window.scrollToLogin = function () {
    var loginForm = document.getElementById('loginmodel');
    if (loginForm) {
        loginForm.scrollIntoView({ behavior: 'smooth', block: 'start' });
    }
}

window.toggleModal = (modalId, isOpen) => {
    const modal = document.getElementById(modalId);
    if (modal) {
        if (isOpen) {
            $(modal).modal('show');
        } else {
            $(modal).modal('hide');
        }
    }
};
window.showNotification = function (message) {
    Notification.requestPermission().then(function (result) {
        if (result === 'granted') {
            new Notification(message);
        }
    });
}


window.focusElement = (element) => {
    element.focus();
};


