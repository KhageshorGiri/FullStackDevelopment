import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';


@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    CommonModule,
    MatButtonModule,
    MatToolbarModule,
    MatIconModule,
    MatMenuModule
    ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent implements OnInit{
  
  @Output() toggleSidebarForMe: EventEmitter<any> = new EventEmitter();

  ngOnInit(): void {
   // ...
  }

  toggleSidebar() {
    this.toggleSidebarForMe.emit();
  }
}
