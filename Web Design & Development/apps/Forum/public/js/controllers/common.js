import { load as loadTemplate } from 'templates';
import { hasUser } from 'user.data';

const $appContainer = $('#app-container');

class CommonController {

  showHideLoginRegister() {
    if(hasUser()) {
      $('#logout-button').removeClass('hidden');
      $('#register-button').addClass('hidden');
      $('#login-button').addClass('hidden');
    }
    else {
      $('#logout-button').addClass('hidden');
      $('#register-button').removeClass('hidden');
      $('#login-button').removeClass('hidden');
    }
  }

  navLinkSelectActive(){
    $('.nav').click(function(e) {
      const target = e.target;
      $(target).parent().addClass('active');
      $(target).parent().siblings().removeClass('active');
    });
  }

  loadAll() {
    this.navLinkSelectActive();
    this.showHideLoginRegister();
  }
}

let commonController = new CommonController();

export { commonController };
