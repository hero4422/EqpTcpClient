# EqpTcpClient (EqpClient / UserClient)
  설비(Equipment)와 사용자(User) 간 TCP 소켓 통신을 테스트하기 위한 WinForms 클라이언트 프로젝트입니다.

  ## 프로젝트 구조
  ```plaintext
  ├── EqpClient/   # 설비 측 TCP 클라이언트
  └── UserClient/  # 사용자 측 TCP 클라이언트

  ## 개발 환경
  - Language: C# (.NET Framework 4.7.2)
  - UI: Windows Forms
  - Logging: Serilog
  - IDE: Visual Studio 2019+

  ## 주요 기능
  - TCP 서버 접속 / 해제
  - 비동기 메시지 송수신 (`BeginRead` / `BeginWrite`)
  - 수신 메시지 이벤트 기반 처리 (`MessageReceived` 이벤트)
  - 송수신 로그 UI 출력

  ## 사용 방법
  1. 테스트할 TCP 서버를 먼저 실행합니다.
  2. `EqpClient` 또는 `UserClient` 를 실행합니다.
  3. IP, Port 입력 후 **접속** 버튼 클릭
  4. 메시지 입력 후 **전송** 버튼으로 메시지 송신

  ## 참고
  - 두 클라이언트를 동시에 실행하여 서버를 통한 양방향 통신 테스트 가능
