import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterOutlet } from '@angular/router';
import {HeaderComponent} from '../app/components/layout/header/header.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, HeaderComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})

export class AppComponent {
  title = 'studentmgnt';
  sideBarOpen = true;

  sideBarToggler() {
    this.sideBarOpen = !this.sideBarOpen;
  }
}
