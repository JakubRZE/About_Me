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
  header: IHeader;

  constructor(private timelineService: TimelineService) {
  }

  ngOnInit(): void {
    // this.timelineService.getHeader().subscribe({
    //   next: header => this.header = header,
    //   error: err => this.errorMessage = err
    // });
}
}
