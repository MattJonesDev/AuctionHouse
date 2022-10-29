import { Component } from '@angular/core';

import { AuthenticationService } from './core/services/authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    constructor(private authenticationService: AuthenticationService) {}

    public isLoggedIn() {
      this.authenticationService.isLoggedIn();
    }

    logout() {
      this.authenticationService.logout();
    }
}
