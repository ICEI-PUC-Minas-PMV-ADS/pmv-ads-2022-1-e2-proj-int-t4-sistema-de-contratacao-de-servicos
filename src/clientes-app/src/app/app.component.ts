import { Component , AfterViewInit} from '@angular/core';

declare var $: any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit{
  title = 'clientes-app';

  ngAfterViewInit(){
    var path = location.pathname;
    
    $('#layoutSidenav_nav .sb-sidenav a.nav-link').each((index:any, element:any) => {
        if ($(element).attr('href') === path) {
            $(element).addClass("active");
        }
    });
     
    $("#sidebarToggle").on("click", function (event: { preventDefault: () => void; }) {
        $("body").toggleClass("sb-sidenav-toggled");
    });
  }
}
