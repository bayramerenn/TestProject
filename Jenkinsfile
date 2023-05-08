pipeline {
  agent any

    environment {
         testContainerName = 'testapi'
         testImageName = 'testproject'
         webAppContainerName = 'testapi'
         webAppImageName = 'testproject'
    }
   stages {
    stage('Start Test Project') {
              when {
                changeset "**/TestProject/**"
              }
              steps {
              

                // Konteyneri durdur ve sil
                sh "docker stop ${testContainerName} || true"
                sh "docker rm ${testContainerName} || true"

                // Görüntüyü sil
                sh "docker image rm ${testImageName} || true"

                // Yeni Docker imajlarını oluştur ve projeyi başlat
                sh 'docker compose build'
                sh 'docker compose up -d'

                echo "Test project basariyla tamamlandi."

                catchError(buildResult: 'FAILURE') {
                    echo 'Test project işlemi başarısız oldu!'
        }
      }
    }
    stage('WebApplication Project') {
              when {
                changeset "**/WebApplication/**"
              }
              steps {
              

                // Konteyneri durdur ve sil
                sh "docker stop ${webAppContainerName} || true"
                sh "docker rm ${webAppContainerName} || true"

                // Görüntüyü sil
                sh "docker image rm ${webAppImageName} || true"

                // Yeni Docker imajlarını oluştur ve projeyi başlat
                sh 'docker compose build'
                sh 'docker compose up -d'

                echo "Web project basariyla tamamlandi."

                catchError(buildResult: 'FAILURE') {
                    echo 'Web project işlemi başarısız oldu!'
        }
      }
    }

  }

}


//   post {
//     always {
//       sh 'docker compose down --remove-orphans -v'
//       sh 'docker compose ps'
//     }
//   }
