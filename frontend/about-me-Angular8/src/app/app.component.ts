import { Component, OnInit } from '@angular/core';
import { TimelineService } from './shared/timeline.service';
import { IHeader } from './interface/IHeader';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'about-me-Angular8';
  errorMessage = '';
  defaultUrl: string = 'https://cdn.pixabay.com/photo/2017/06/13/12/53/profile-2398782_960_720.png';
  header: IHeader;

  constructor(private timelineService: TimelineService) {
  }

  ngOnInit(): void {
    this.timelineService.getHeader().subscribe({
      next: header => this.header = header,
      error: err => this.errorMessage = err
    });

    
}
}
