pipeline {
  agent any
  stages {
    stage('Start container') {
              // Değişiklik yapılan servis için deploy işlemini gerçekleştir
              //C:\Users\Bayram\source\repos\TestProject\TestProject\TestProject.csproj
              when {
                changeset "**/TestProject/Controllers/*"
              }
              steps {
                def containerName = 'testapi'
                def imageName = 'testproject'

                // Konteyneri durdur ve sil
                sh "docker stop ${containerName} || true"
                sh "docker rm ${containerName} || true"

                // Görüntüyü sil
                sh "docker image rm ${imageName}:latest || true"

                // Yeni Docker imajlarını oluştur ve projeyi başlat
                sh 'docker-compose build'
                sh 'docker-compose up -d'
              }
            }
   
  }
//   post {
//     always {
//       sh 'docker compose down --remove-orphans -v'
//       sh 'docker compose ps'
//     }
//   }
}
