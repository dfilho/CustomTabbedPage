# CustomTabbedPage
CustomTabbedPage para navegação retirando as tabs

No arquivo:
  Controls -> CustomTabbedPage.cs
  É encontrado o código para a customização das abas (cor de fundo e texto).
  
Em Views estão os xamls que implementão a CustomTabbedPage, sendo TabbedView.xaml o arquivo que contém as tags para a visualização da Aba. Ela exibira os arquivos Page1View e Page2View.

Em Page1View há um botão que faz a navegação, utilizando NavigationPage, para o arquivo Pagina1NavegacaoView;

Nos projetos CustomTabbedPage.Android e CustomTabbedPage.iOS estão os renderers que adequam para cada plataforma a aba da maneira correta.
