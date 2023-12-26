import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatPaginator, MatPaginatorModule} from '@angular/material/paginator';
import {MatSort, MatSortModule} from '@angular/material/sort';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatIconModule} from '@angular/material/icon';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { Course } from '../../core/interfaces/course.interface';
import { CourseService } from '../../core/services/course.service';

@Component({
  selector: 'app-courses',
  standalone: true,
  imports: [CommonModule,MatFormFieldModule, MatInputModule, RouterLink, RouterLinkActive,
    MatTableModule, MatSortModule, MatPaginatorModule, MatIconModule],
  templateUrl: './courses.component.html',
  styleUrl: './courses.component.scss'
})

export class CoursesComponent implements OnInit {

  courseService! : CourseService;

  courseTableDisplayColumns: string[] = ['id', 'courseName', 'description', 'faculty', 'action']
  courseTableDataSource!: MatTableDataSource<Course>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  
  allCourses!: Course[];
  constructor(courseService:CourseService){
    this.courseService = courseService;
    this.allCourses = this.courseService.getAllCourses();
    // to do ....
    this.courseTableDataSource = new MatTableDataSource(this.allCourses);
  }

  //********************************************************
  // Private Functions 
  //********************************************************
  ngOnInit(): void {
    //.. 
  }

  ngAfterViewInit() {
    this.courseTableDataSource.paginator = this.paginator;
    this.courseTableDataSource.sort = this.sort;
  }



  //********************************************************
  // Private Functions 
  //********************************************************
}
